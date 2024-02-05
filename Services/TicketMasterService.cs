using BhamBands.Models;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BhamBands.Services
{
    public class TicketmasterService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "i0dHdnIp8pzV4QTRsvAOyVEARhM79nA2";
        private readonly string _baseApiUrl = "https://app.ticketmaster.com/discovery/v2/events";

        public TicketmasterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EventFetchResult> GetEventsAsync(int page = 1, string city = "Birmingham", string countryCode = "US", string stateCode = "AL")
        {
            List<Event> allEvents = new List<Event>();
            string pageParam = page > 1 ? $"&page={page - 1}" : "";
            string url = $"{_baseApiUrl}?apikey={_apiKey}{pageParam}&size=20&locale=*&city={Uri.EscapeDataString(city)}&countryCode={countryCode}&stateCode={stateCode}";

            string nextPageUrl = null;

            while (!string.IsNullOrEmpty(url))
            {
                var response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonSerializer.Deserialize<ApiResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (apiResponse != null && apiResponse.Embedded?.events != null)
                    {
                        allEvents.AddRange(apiResponse.Embedded.events);
                        // Update nextUrl for the next iteration based on the 'next' link.
                        // This will be null or omitted when there are no more pages, ending the loop.
                        url = apiResponse.links?.next?.href;
                    }
                    else
                    {
                        // If the response doesn't contain the expected data, end the loop.
                        url = null;
                    }
                }
                else
                {
                    // Log or handle errors as appropriate for your application
                    throw new HttpRequestException($"API call failed with status code: {response.StatusCode}");
                    // Optionally, you might want to break out of the loop instead of throwing an exception.
                }
            }


            return new EventFetchResult
            {
                Events = allEvents,
                NextPageUrl = nextPageUrl
            };
        }


        private List<Event> DeserializeAndMapToEvents(string jsonResponse)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var apiResponse = JsonSerializer.Deserialize<ApiResponse>(jsonResponse, options);
            return apiResponse?.Embedded?.events ?? new List<Event>();
        }
    }
}
