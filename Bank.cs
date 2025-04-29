using System;

namespace BasicBankingSystem
{
    class BankAcc
    {
        public string accHolder;
        public string accNumber;
        public decimal balance;

        public BankAcc(string name, string accnumber)
        {
            accHolder = name;
            accNumber = accnumber;
            balance = 0;
        }

        public void Deposit(decimal amt)
        {
            if (amt > 0)
            {
                balance += amt;
                Console.WriteLine($"Deposited ₹{amt}. New Balance: ₹{balance}");
            }
            else
            {
                Console.WriteLine($"Entered amount is invalid,Please Enter valid Deposite amount .");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdraw Amount: ₹{amount}.\n New Balance: ₹{balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Account Holder: {accHolder}");
            Console.WriteLine($"Account Number: {accNumber}");
            Console.WriteLine($"Current Balance: ₹{balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----* SIMPLE BANK PROGRAM *---");
            Console.Write("Enter Account Holder Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            string accNumber = Console.ReadLine();

            BankAcc account = new BankAcc(name, accNumber);
            bool c = true;

            while(c)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                // Console.Write("Option: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ₹");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        account.Deposit(deposit);
                        break;

                    case "2":
                        Console.Write("Enter amount to withdraw: ₹");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                        account.Withdraw(withdraw);
                        break;

                    case "3":
                        account.ShowBalance();
                        break;

                    case "4":
                        c=false;
                        Console.WriteLine("Thank you");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
