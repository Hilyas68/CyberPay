using CyberPay.Cmd.Payload.Quickteller;
using System.Collections.Generic;

namespace CyberPay.Cmd.Providers
{
    public interface IQuickTellerBillProvider
    {
        NameEnquiry ValidateName(string bankCode, string accountId);
        List<QuicktellerBillCategory> GetBillCategories();
        List<QuicktellerBiller> GetBillers();
        List<QuicktellerBank> GetBankCodes();
        BillsPaymentResponseViewModel SendBillPaymentNotification(string paymentcode, string customerUniqueReference, string customerMobile, string customerEmail, string transactionUniqueReference, decimal amount);
        List<BillPaymentTransaction> SendBillPaymentTransaction(decimal amount, string pinData, string secureData, long msisdn, string transactionRef, long cardBin);
        QuicktellerCustomerViewModel ValidateCustomer(string paymentCode, string subscriberId);

        QuicktellerPaymentItemsViewModel GetBillerById(string billerId);
    }
}
