using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    internal class UserRegister
    {
        public Dictionary<string, User> UserList { get; private set; } = new Dictionary<string, User>()
        {
            ["admin"] = new Admin
            {
                Username = "admin1",
                Password = "Admin123",
                FullName = "Sara Struktur"
            },
            ["test"] = new Customer("test1", "Test123", "Testa Testsson")

        };

        public void DeleteCustomerInRegister(string key)
        {
            //Tar emot parametrar från DeleteCustomer i Admin class
            //Faktiska raderingen i listan sker här
            UserList.Remove(key);
        }
    }
}
