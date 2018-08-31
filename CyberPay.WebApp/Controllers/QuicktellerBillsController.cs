using CyberPay.Cmd.Payload.Quickteller;
using CyberPay.Cmd.Providers;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace CyberPay.WebApp.Controllers
{
    [RoutePrefix("api/quickteller")]
    public class QuicktellerBillsController : ApiController
    {
        private readonly IQuickTellerBillProvider billProvider;

        public QuicktellerBillsController() : this(new QuickTellerBillProvider())
        {
        }

        public QuicktellerBillsController(IQuickTellerBillProvider billProvider)
        {
            this.billProvider = billProvider;
        }

        [Route("getbillers")]
        public HttpResponseMessage GetBillers()
        {
            var billers = billProvider.GetBillers();
            ApiResult<List<QuicktellerBiller>> result = new ApiResult<List<QuicktellerBiller>>();
            return Request.CreateResponse(billers);
        }


        [Route("getBanks")]
        public HttpResponseMessage GetBanks()
        {
            var banks = billProvider.GetBankCodes();
            ApiResult<List<QuicktellerBank>> result = new ApiResult<List<QuicktellerBank>>();
            result.Data = banks;
            return Request.CreateResponse(result);
        }

        [HttpPost]
        [Route("sendpaymentTransaction")]
        public HttpResponseMessage SendPaymentTraction(BillPaymentTransaction billPayment)
        {
            var banks = billProvider.SendBillPaymentTransaction(billPayment.Amount, billPayment.PinData, billPayment.SecureData, billPayment.Msisdn, billPayment.TransactionRef, billPayment.CardBin);
           
            ApiResult<List<BillPaymentTransaction>> result = new ApiResult<List<BillPaymentTransaction>>();
            result.Data = banks;
            return Request.CreateResponse(result);
        }
    }
}