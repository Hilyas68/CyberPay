using CyberPay.Cmd.Providers;
using System;

namespace CyberPay.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var billProvider = new QuickTellerBillProvider();

            var banks = billProvider.GetBankCodes();

            foreach (var item in banks)
            {
                Console.WriteLine($"Bank Name: {item.bankName} \t Bank Code: {item.bankCode}");

            }


            var biller = billProvider.GetBillerById("104");


            foreach (var item in biller.PaymentItems)
            {
                Console.WriteLine($"{item.PaymentItemName}");
            }

            Console.Read();
        }
    }
}
