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
        // Base URL adjusted to not include the API key
        private readonly string _baseApiUrl = "https://app.ticketmaster.com/discovery/v2/";

        public TicketmasterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            var eventsList = new List<Event>();
            // Construct the request URL with the API key and parameters at the time of making the request
            var url = $"{_baseApiUrl}events.json?apikey={_apiKey}&size=10";

            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                eventsList = DeserializeAndMapToEvents(content);
            }
            else
            {
                // Handle errors or unsuccessful status codes accordingly
                throw new HttpRequestException($"Error fetching events: {response.StatusCode}");
            }

            return eventsList;
        }

        private List<Event> DeserializeAndMapToEvents(string jsonResponse)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var apiResponse = JsonSerializer.Deserialize<ApiResponse>(jsonResponse, options);
            return apiResponse?.Embedded?.events ?? new List<Event>();
        }
    }
}
