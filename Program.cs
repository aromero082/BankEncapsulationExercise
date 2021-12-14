using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var aaronsAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());
            aaronsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thankyou Your balance is now {aaronsAccount.GetBalance()}");
        }
    }
}
