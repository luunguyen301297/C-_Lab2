using System;

namespace Lab2
{
    class Bank
    {
        private List<User> userList;

        public Bank()
        {
            userList = new List<User>();
            userList.Add(new User("duongtran", "duong123"));
            userList.Add(new User("nghianguyen", "nghia123"));
        }

        public List<User> getUserList()
        {
            return userList;
        }
    }

}