/* Write a program to calculate the credit card balance after one year
if a person only pays the minimum monthly payment required by the credit card company each month.
The following variables contain values as described below:

balance - the outstanding balance on the credit card
annualInterestRate - annual interest rate as a decimal
monthlyPaymentRate - minimum monthly payment rate as a decimal

For each month, calculate statements on the monthly payment and remaining balance. At the end of 12 months, print out the remaining balance.
Be sure to print out no more than two decimal digits of accuracy

A summary of the required math is found below:

Monthly interest rate = (Annual interest rate) / 12.0
Minimum monthly payment = (Minimum monthly payment rate) x (Previous balance)
Monthly unpaid balance = (Previous balance) - (Minimum monthly payment)
Updated balance each month = (Monthly unpaid balance) + (Monthly interest rate x Monthly unpaid balance)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardBalance
{
    public class Accountant
    {
        public float balance;
        public double annualInterestRate;
        public float monthlyPaymentRate;
        public Accountant(float balance, double annualInterestRate, float monthlyPaymentRate) 
        {
            this.balance = balance;
            this.annualInterestRate = annualInterestRate;
            this.monthlyPaymentRate = monthlyPaymentRate;
        }
        public float BalanceCheck () {
            return this.balance;
        }
        public double AnnualInterestRateCheck()
        {
            return this.annualInterestRate;
        }
        public float MonthlyPaymentRateCheck()
        {
            return this.monthlyPaymentRate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountant Icek = new Accountant(1000, 12.50, 100);
            Console.WriteLine("Lets talk to the Accountant!");

            //Balance
            Console.WriteLine("What is the current balance?");
            Console.WriteLine("Icek says: " + Icek.BalanceCheck());

            //Interest rate
            Console.WriteLine("What is the current annual interest rate?");
            Console.WriteLine("Icek says: " + Icek.AnnualInterestRateCheck());

            //Monthly payment
            Console.WriteLine("What is the monthly payment?");
            Console.WriteLine("Icek says: " + Icek.MonthlyPaymentRateCheck());
        }
    }
}
