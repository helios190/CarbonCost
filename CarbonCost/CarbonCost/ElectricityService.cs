using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CarbonCost
{
    public class ElectricityService
    {
        private readonly HttpClient _httpClient;

        public ElectricityService(string apiKey)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://www.carboninterface.com/api/v1/")
            };
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        }

        public virtual async Task<double> GetElectricityEmissionsAsync(string unit, double value, string country, string state = null)
        {
            // Prepare payload
            var payload = new
            {
                type = "electricity",
                electricity_unit = unit,
                electricity_value = value,
                country = country,
                state = state
            };

            var payloadJson = JsonSerializer.Serialize(payload, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            Console.WriteLine($"Payload: {payloadJson}");

            // Make API request
            var content = new StringContent(payloadJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("estimates", content);

            // Handle errors
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"API Error: {response.StatusCode}\nDetails: {errorContent}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            MessageBox.Show($"Raw API Response: {responseContent}");
            Console.WriteLine($"Response: {responseContent}");

            // Deserialize response
            var responseData = JsonSerializer.Deserialize<ElectricityEstimateResponse>(
    responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (responseData?.Data?.Attributes == null)
            {
                throw new Exception("Invalid response format from API.");
            }

            double carbonKg = responseData.Data.Attributes.CarbonKg;

            // Debugging: Show full deserialized response and extracted value
            string debugResponseData = JsonSerializer.Serialize(responseData, new JsonSerializerOptions { WriteIndented = true });
            MessageBox.Show($"ResponseData Object:\n{debugResponseData}", "Debugging ResponseData", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"Extracted CarbonKg Value: {carbonKg}", "Debugging CarbonKg", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return carbonKg;


        }

        // Nested classes for deserialization
        public class ElectricityEstimateResponse
        {
            [JsonPropertyName("data")]
            public ElectricityEstimateData Data { get; set; }
        }

        public class ElectricityEstimateData
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("attributes")]
            public ElectricityEstimateAttributes Attributes { get; set; }
        }

        public class ElectricityEstimateAttributes
        {
            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }

            [JsonPropertyName("electricity_unit")]
            public string ElectricityUnit { get; set; }

            [JsonPropertyName("electricity_value")]
            public decimal ElectricityValue { get; set; }

            [JsonPropertyName("estimated_at")]
            public DateTime EstimatedAt { get; set; }

            [JsonPropertyName("carbon_g")]
            public long CarbonG { get; set; }

            [JsonPropertyName("carbon_lb")]
            public double CarbonLb { get; set; }

            [JsonPropertyName("carbon_kg")]
            public double CarbonKg { get; set; }

            [JsonPropertyName("carbon_mt")]
            public double CarbonMt { get; set; }
        }

    }
}
