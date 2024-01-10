using System;

namespace Lab2
{
    class User
    {
        private string userName;
        private string password;
        private long balance;
        private const int MIN_BALANCE = 50000;
        private const int MIN_DEPOSIT = 500000;
        private const int MIN_WITHDRAW = 50000;
        private const decimal fee = 0.067M;

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            balance += MIN_BALANCE;
        }

        public bool withDraw(int money)
        {
            if (money % MIN_WITHDRAW != 0)
            {
                Console.WriteLine("The withdrawal amount must be a multiple of 50000 VND");
                return false;
            }

            decimal moneyBeforeFee = money + money * (fee / 100);
            decimal newBalance = getBalance() - moneyBeforeFee;
            long roundedBalance = (long)Math.Round(newBalance, MidpointRounding.AwayFromZero);

            if (roundedBalance >= MIN_BALANCE)
            {
                Console.WriteLine("You have withdrawn: " + money + " VND");
                Console.WriteLine("Fee: " + fee + "%");
                balance = roundedBalance;
                Console.WriteLine("Balance: " + getBalance() + " VND");
                return true;
            }
            else
            {
                throw new NotEnoughMoneyException("Insufficient balance");
            }
        }

        public bool deposit(long money)
        {
            if (money >= MIN_DEPOSIT && money % MIN_DEPOSIT == 0)
            {
                Console.WriteLine("Deposits: " + money + " VND");
                balance += money;
                Console.WriteLine("Balance: " + getBalance());
                return true;
            }
            Console.WriteLine("The deposit amount must be a multiple of " + MIN_DEPOSIT + "VND");
            return false;
        }

        public string getUserName()
        {
            return userName;
        }


        public void setUserName(string userName)
        {
            this.userName = userName;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public long getBalance()
        {
            return balance;
        }

        public string toString()
        {
            return "Username: " + getUserName() + "\n"
                + "Balance: " + getBalance();
        }
    }

    class NotEnoughMoneyException : ApplicationException
    {
        public NotEnoughMoneyException(String message) : base(message) { }
    }

}