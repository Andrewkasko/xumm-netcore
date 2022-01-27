using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xumm_netcore.src.Model
{
    public class Request
    {
        public string user_token { get; set; }
        public TxJson txjson { get; set; }
        public string txblob { get; set; }
        public Options options { get; set; }
        public CustomMeta custom_meta { get; set; }
    }
    public class ReturnUrl
    {
        public string app { get; set; }
        public string web { get; set; }
    }

    public class Options
    {
        public bool submit { get; set; }
        public bool multisign { get; set; }
        public int expire { get; set; }
        public ReturnUrl return_url { get; set; }
    }

    public class TxJson {
        public string TransactionType { get; set; }
        public string Account { get; set; }
        public string Owner { get; set; }
        public string TokenID { get; set; }
        public string Amount { get; set; }
        public string Issuer { get; set; }
        public int TransactionFee { get; set; }
        public int TokenTaxon { get; set; }
        public string URI { get; set; }
        public int Flags { get; set; }
        public int Expiration { get; set; }
        public string Destination { get; set; }
        public string[] TokenIDs { get; set; }
    }
}
