using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xumm_netcore.src.Interface;
using xumm_netcore.src.Model;

namespace xumm_netcore.src.Repository
{
    public class Ping : IPing
    {
        public async Task<PingResponse> PingXumm()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://xumm.app/api/v1/platform/ping"),
                Headers =
                    {
                        { "Accept", "application/json" },
                        { "X-API-Key", "" }, // API-KEY REQUIRED
                        { "X-API-Secret", "" }, // API-SECRET REQUIRED
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<PingResponse>(body);
            }
        }
    }
}
