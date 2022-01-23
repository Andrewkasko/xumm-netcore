using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using xumm_netcore.src.Interface;
using xumm_netcore.src.Model;

namespace xumm_netcore.src.Repository
{
    public class AppSignIn : IAppSignIn
    {
        public async Task<RequestResponse> SignIn()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://xumm.app/api/v1/platform/payload"),
                Headers =
                    {
                        { "Accept", "application/json" },
                        { "X-API-Key", "" }, // API-KEY REQUIRED
                        { "X-API-Secret", "" }, // API-SECRET REQUIRED
                    },
                Content = new StringContent("{\"txjson\":{\"TransactionType\":\"SignIn\"}}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();

                return Newtonsoft.Json.JsonConvert.DeserializeObject<RequestResponse>(body);
            }
        }
    }
}
