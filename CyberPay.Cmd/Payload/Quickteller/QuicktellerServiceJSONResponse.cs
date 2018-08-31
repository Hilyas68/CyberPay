using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberPay.Cmd.Payload.Quickteller
{
    public class QuicktellerServiceJSONResponse : QuicktellerBaseServiceResponse
    {
        [JsonProperty("categorys")]
        public List<QuicktellerBillCategory> categories { get; set; }
        [JsonProperty("billers")]
        public List<QuicktellerBiller> Billers { get; set; }
        [JsonProperty("paymentitems")]
        public List<BillPaymentItem> paymentsitems { get; set; }
        [JsonProperty("customers")]
        public List<QuicktellerCustomerViewModel> customers { get; set; }
        [JsonProperty("accounxtName")]
        public NameEnquiry accountName { get; set; }
        [JsonProperty("banks")]
        public List<QuicktellerBanks> Banks { get; set; }
    }
}
