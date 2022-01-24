using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using xumm_netcore.src.Interface;
using xumm_netcore.src.Model;

namespace xumm_netcore.src.Repository
{
    public class NFToken : INFToken
    {
        public async Task<RequestResponse> TokenAction(Request request) {
            var client = new HttpClient();
            string jsonString = JsonConvert.SerializeObject(
               request,
               Newtonsoft.Json.Formatting.None,
               new JsonSerializerSettings
               {
                   NullValueHandling = NullValueHandling.Ignore
               });

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://xumm.app/api/v1/platform/payload"),
                Headers =
                    {
                        { "Accept", "application/json" },
                        { "X-API-Key", "" }, // API-KEY REQUIRED
                        { "X-API-Secret", "" }, // API-SECRET REQUIRED
                    },
                Content = new StringContent(jsonString)
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            using (var response = await client.SendAsync(httpRequest))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<RequestResponse>(body);
            }
        }

    }
}
