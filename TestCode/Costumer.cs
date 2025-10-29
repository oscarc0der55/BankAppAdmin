﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    internal class Customer : User
    {
        //Constructor; set IsAdmin to falsem also making sure that every customer har username, password and a fullname.
        public Customer(string username, string password, string fullName)
        {
            IsAdmin = false;

            Username = username;
            Password = password;
            FullName = fullName;
        }

    }
}
