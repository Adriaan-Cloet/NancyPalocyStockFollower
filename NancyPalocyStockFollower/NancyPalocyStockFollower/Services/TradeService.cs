using NancyPalocyStockFollower.Models;
using System.Text.Json;

namespace NancyPalocyStockFollower.Services
{
    public class TradeService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://house-stock-watcher-data.s3-us-west-2.amazonaws.com/data/all_transactions.json";

        public TradeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; NancyPelosiTracker/1.0)");
        }

        public async Task<List<CongressTrade>> GetPelosiTradesAsync()
        {
            var response = await _httpClient.GetStringAsync(ApiUrl);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var allTrades = JsonSerializer.Deserialize<List<CongressTrade>>(response, options) 
                ?? new List<CongressTrade>();

            return allTrades
                .Where(t => t.Representative != null && t.Representative.Contains("Pelosi", StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(t => t.TransactionDate)
                .ToList();
        }
    }
}
