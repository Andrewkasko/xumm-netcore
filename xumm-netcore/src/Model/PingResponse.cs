using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xumm_netcore.src.Model
{
    public class PingResponse
    {
        public bool pong { get; set; }
        public Auth auth { get; set; }
        public error error { get; set; }
    }
    public class Quota
    {
    }

    public class Application
    {
        public string uuidv4 { get; set; }
        public string name { get; set; }
        public string webhookurl { get; set; }
        public int disabled { get; set; }
    }

    public class Call
    {
        public string uuidv4 { get; set; }
    }

    public class Auth
    {
        public Quota quota { get; set; }
        public Application application { get; set; }
        public Call call { get; set; }
    }
}
