using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuDisplay();

            Console.WriteLine("Please enter your Account number to calculate your energy bill: ");
            int customerAcc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name associated with the accouunt: ");
            string customerName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your units of energy consumed for the current month: ");
            double unitCons = Convert.ToDouble(Console.ReadLine());

            CalcBillCharge(customerAcc, customerName, unitCons);





        }
        private static void CalcBillCharge(int customerAcc, string customerName, double unitsCons)
        {
            double unitcharge1 = 1.20;
            double unitCharge2 = 1.50;
            double unitCharge3 = 1.80;
            double unitCharge4 = 2.00;
            double surChargePercent = 15.0;
            double totalBill = 0;
            double surChargeAmt = 0;
            double netAmt = 0;

            if (unitsCons <= 199)
            {
                totalBill = unitsCons * unitcharge1;



            }
            else if (unitsCons >= 200 && unitsCons < 400)
            {
                totalBill = unitsCons * unitCharge2;

            }
            else if (unitsCons > 400 && unitsCons < 600)
            {
                totalBill = unitsCons * unitCharge3;




            }
            else if (unitsCons >= 600)
            {
                totalBill = unitsCons * unitCharge4;


            }// after all calcs are made you need to put the last two ifs in to make sure if any of the total bills exceed 400 then a surcharge is charged to that total bill amount
            if (totalBill > 400)
            {
                surChargeAmt = totalBill * (surChargePercent / 100);
            }

            netAmt = totalBill + surChargeAmt;


            Console.WriteLine($"CustomerID: {customerAcc}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Units consumed: {unitsCons}");
            Console.WriteLine($"Total Amount Charges: ${totalBill:F2}");
            if (surChargeAmt > 0)
            {
                Console.WriteLine($"Surcharge Amount: ${surChargeAmt:F2}");
            }
            Console.WriteLine($"Net amount paid by the Customer: ${netAmt:F2}");

        }

        private static void MenuDisplay()
        {
            Console.Write("------------Unit---------------");
            Console.Write("-----------Charge/Unit----------------\n");
            Console.Write("\tup to 199");
            Console.Write("\t\t\t\t\t@1.20\n");
            Console.Write("\t200+ < 400");
            Console.Write("\t\t\t\t\t@1.50\n");
            Console.Write("\t400+ < 600");
            Console.Write("\t\t\t\t\t@1.80\n");
            Console.Write("\t600+");
            Console.Write("\t\t\t\t\t\t@2.00");
            Console.WriteLine();
            Console.WriteLine("If bill exceeds $400 then a surcharge of 15% will be charged");
        }
    }
}
