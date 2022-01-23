using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xumm_netcore.src.Model
{
    public class Refs
    {
        public string qr_png { get; set; }
        public string qr_matrix { get; set; }
        public List<string> qr_uri_quality_opts { get; set; }
        public string websocket_status { get; set; }
    }
}
