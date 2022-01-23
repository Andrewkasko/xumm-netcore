using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xumm_netcore.src.Model
{
    public class RequestResponse
    {
        public string uuid { get; set; }
        public Next next { get; set; }
        public Refs refs { get; set; }
        public bool pushed { get; set; }
    }
}
