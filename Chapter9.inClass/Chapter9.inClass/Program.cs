using System;

namespace Chapter9.inClass
{
    class Program
    {
        static void AccountAccess()
        {
            int[,] accountNumber = new int[,] { { 12345, 54321 } };
            Console.Write("Please enter Account #:");
            int userAccountEntry = int.Parse(Console.ReadLine());
            Console.Write("Please enter PIN #:");
            int userPinEntry = int.Parse(Console.ReadLine());

            int[,] accountCreds = new int[,] { { userAccountEntry, userPinEntry } };

            while (accountCreds[0,0] != accountNumber[0,0])
            {
                Console.WriteLine("Invaild Entry, try again.");
                userAccountEntry = int.Parse(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            AccountAccess();

            decimal accountBalance = 0;
            //prompt the user with a menu and ask them if they want to do a deposit, a withdrawal, or exit the application.
            Console.WriteLine("Your current balance is ${0}", accountBalance);
            Console.Write("1.Deposit\n2.Withdrawal\n3.Display Balance\n4.Exit\nPlease enter desired action:");
            int menuChoice = int.Parse(Console.ReadLine());
            while (menuChoice != 4)
            {
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Your current balance is ${0}", accountBalance);
                        Console.Write("Please enter amount to deposit:");
                        decimal depositEntry = Decimal.Parse(Console.ReadLine());
                        accountBalance += depositEntry;
                        break;
                    case 2:
                        Console.WriteLine("Your current balance is ${0}", accountBalance);
                        Console.Write("Please enter amount to withdraw:");
                        decimal withdrawEntry = Decimal.Parse(Console.ReadLine());
                        if (withdrawEntry > accountBalance)
                            Console.WriteLine("Error: Not enough funds.");
                        else
                        {
                            accountBalance -= withdrawEntry;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Your current balance is ${0}", accountBalance);
                        break;
                    default:
                        Console.WriteLine("Invaild entry.");
                        break;
                }
                Console.WriteLine("Would you like to do anything else?:\n1.Deposit\n2.Withdrawal\n3.Display Balance\n4.Exit");
                menuChoice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Thank you for your business, nerd.");
            Console.ReadLine();
        }
    }
}
