using Newtonsoft.Json;

namespace CyberPay.Cmd.Payload.Quickteller
{
    public class QuicktellerBank
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("cbnCode")]
        public string cbnCode { get; set; }
        [JsonProperty("bankName")]
        public string bankName { get; set; }
        [JsonProperty("bankCode")]
        public string bankCode { get; set; }
    }
}