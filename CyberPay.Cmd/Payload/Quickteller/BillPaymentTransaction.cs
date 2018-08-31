using Newtonsoft.Json;
using System;

namespace CyberPay.Cmd.Payload.Quickteller
{
    public class BillPaymentTransaction
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("pinData")]
        public String PinData { get; set; }
        [JsonProperty("secureData")]
        public String SecureData { get; set; }
        [JsonProperty("msisdn")]
        public long Msisdn { get; set; }
        [JsonProperty("transactionRef")]
        public String TransactionRef { get; set; }
        [JsonProperty("cardBin")]
        public long CardBin { get; set; }
    }
}

