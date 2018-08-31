using CyberPay.Cmd.Payload.Quickteller;
using System;

namespace CyberPay.Cmd.Providers
{
    public class PaymentTransactionResponseViewModel : QuicktellerBaseServiceResponse
    {
        public String ResponseCode { get; set; }
        public String TransactionRef { get; set; }
        public String ResponseMessage { get; set; }
        public String AmountPaid { get; set; }
    }
}