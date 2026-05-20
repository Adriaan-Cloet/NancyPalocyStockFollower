using System.Text.Json.Serialization;

namespace NancyPalocyStockFollower.Models
{
    public class CongressTrade
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }

        [JsonPropertyName("representative")]
        public string Representative { get; set; }

        [JsonPropertyName("transaction_type")]
        public string Transaction {  get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("transaction_date")]
        public string TransactionDate { get; set; }

        [JsonPropertyName("disclosure_date")]
        public string DisclosureDate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
