using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xumm_netcore.src.Model;

namespace xumm_netcore.src.Interface
{
    public interface INFToken
    {
        Task<RequestResponse> TokenAction(Request request);
        Task<PayloadResponse> GetPayload(string payloadUuid);
    }
}
