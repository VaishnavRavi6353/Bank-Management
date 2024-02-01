namespace Bank_Management
{
    class BankAccount
    {
        private string owner;
        private double balance;

        public BankAccount(string name, double initialbalance)
        {
            owner = name;
            balance = initialbalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} is deposited to {owner}'s account. Current balace: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid Amount to be deposit.");
            }
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && balance > amount)
            {
                balance -= amount;
                Console.WriteLine($"{amount} is wothdraw from {owner}'s account. Current balance:{balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
                return false;
            }
        }

        public void GetBalance() 
        {
            Console.WriteLine($"Account Holder: {owner}");
            Console.WriteLine($"Account Balance: {balance}");
        }

        public void Transfer(BankAccount account, double amount) 
        {
            if(Withdraw(amount))
            {   
                account.Deposit(amount);
                Console.WriteLine($"{amount} is transferd to {account.o}'s account from {owner}'s Account.  Current balance:{balance}");
            }
            else
            {
                Console.WriteLine("Transaction Failed.");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount Account1 = new BankAccount("Ravi", 10000);
            BankAccount Account2 = new BankAccount("Mitesh", 15000);

            Account1.GetBalance();
            Account2.GetBalance();

            Account1.Deposit(5600);
            Account1.GetBalance();

            Account2.Withdraw(2200);
            Account2.GetBalance();

            Account2.Transfer(Account1, 1500);
            Account1.GetBalance();
            Account2.GetBalance();

            Console.ReadLine();
        }
    }
}
