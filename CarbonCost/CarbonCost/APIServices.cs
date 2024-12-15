using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CarbonCost
{
    public class APIServices : IAPIServices
    {
        private readonly HttpClient _httpClient;

        public APIServices(string apiKey)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://www.carboninterface.com/api/v1/")
            };
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        }

        public async Task<double> GetElectricityEmissionsAsync(string unit, double value, string country, string state = null)
        {
            var payload = new
            {
                type = "electricity",
                electricity_unit = unit,
                electricity_value = value,
                country = country,
                state = state
            };

            return await PostApiRequestAsync(payload);
        }

        public async Task<double> GetShippingEmissionsAsync(double weight, string weightUnit, double distance, string distanceUnit, string transportMethod)
        {
            var payload = new
            {
                type = "shipping",
                weight_value = weight,
                weight_unit = weightUnit,
                distance_value = distance,
                distance_unit = distanceUnit,
                transport_method = transportMethod
            };

            return await PostApiRequestAsync(payload);
        }

        public async Task<double> GetFuelCombustionEmissionsAsync(string fuelType, double quantity, string unit)
        {
            var payload = new
            {
                type = "fuel_combustion",
                fuel_source_type = fuelType,
                fuel_source_unit = unit,
                fuel_source_value = quantity
            };

            return await PostApiRequestAsync(payload);
        }


        /// <summary>
        /// Shared method to send a POST request and parse the response.
        /// </summary>
        private async Task<double> PostApiRequestAsync(object payload)
        {
            var payloadJson = JsonSerializer.Serialize(payload, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });

            var content = new StringContent(payloadJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("estimates", content);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"API Error: {response.StatusCode}\nDetails: {errorContent}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var responseData = JsonSerializer.Deserialize<ApiResponse>(
                responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (responseData?.Data?.Attributes == null)
                throw new Exception("Invalid response format from API.");

            return responseData.Data.Attributes.CarbonKg;
        }

        // Shared response structure for all types
        public class ApiResponse
        {
            public ApiData Data { get; set; }
        }

        public class ApiData
        {
            public ApiAttributes Attributes { get; set; }
        }

        public class ApiAttributes
        {
            [JsonPropertyName("carbon_kg")]
            public double CarbonKg { get; set; }
        }

    }
}
