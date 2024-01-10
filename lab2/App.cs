using System;

namespace Lab2
{
    class MenuController
    {
        Bank bank;
        User user;
        List<User> userList;
        // duongtran / duong123
        // nghianguyen / nghia123

        public MenuController()
        {
            bank = new Bank();
            userList = bank.getUserList();
        }

        public bool checkLogin(string userName, string password)
        {
            foreach (User u in userList)
            {
                if (string.Equals(userName, u.getUserName(), StringComparison.OrdinalIgnoreCase))
                {
                    if (string.Equals(password, u.getPassword(), StringComparison.OrdinalIgnoreCase))
                    {
                        user = u;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong password");
                        return false;
                    }
                }
            }
            Console.WriteLine("Username does not exist");
            return false;
        }

        public bool login(int numOfAttempts)
        {
            while (numOfAttempts >= 0)
            {
                Console.WriteLine("Enter username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                if (checkLogin(username, password))
                {
                    Console.WriteLine("Login successful!");
                    return true;
                }
                Console.WriteLine(numOfAttempts + " tries left");
                numOfAttempts--;
            }

            Console.WriteLine("Exceeded maximum login attempts");
            Environment.Exit(0);
            return false;
        }

        public string showUserInfo()
        {
            return user.toString();
        }

        public void WithDraw(int money)
        {
            user.withDraw(money);
        }

        public void Deposit(int money)
        {
            user.deposit(money);
        }

        public void showLoginMenu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");
        }

        public void showTransactionMenu()
        {
            Console.WriteLine("1. Show Info");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");
        }



        public static void Main(string[] args)
        {
            MenuController menu = new MenuController();
            menu.showLoginMenu();

            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1) menu.login(3);
            else Environment.Exit(0);

            do
            {
                menu.showTransactionMenu();
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(menu.showUserInfo());
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount you want to withdraw: ");
                        int money = Convert.ToInt32(Console.ReadLine());
                        menu.WithDraw(money);
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount you want to send: ");
                        money = Convert.ToInt32(Console.ReadLine());
                        menu.Deposit(money);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Wrong keywords, try again!");
                        continue;
                }
            } while (option != 4);
        }
    }
}