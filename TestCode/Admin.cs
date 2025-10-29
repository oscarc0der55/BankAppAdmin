﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    internal class Admin : User
    {
        //Constructor; set IsAdmin to true
        public Admin()
        {
            IsAdmin = true;
        }

        public void ViewCustomer(UserRegister users)
        {
            User currentUser = new();
            //Doesn't show the password for user
            foreach (KeyValuePair<string, User> userlist in users.UserList)
            {
                currentUser = userlist.Value;
                Console.WriteLine($"Roll: {userlist.Key}, Användarnamn: {currentUser.Username}, Namn: {currentUser.FullName}\n");
            }

        }
        public void DeleteCustomer(UserRegister users)
        {
            bool isRunning = true;
            string username;
            //Vad händer om man kommer hit av misstag, tar vi bort while-loopen eller lägger vi till en till else-if sats för att gå tillbaka
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Välj ett användarnamn som ska tas bort");

                username = InputValidation.TrimmedString();
                if (DoesUsernameExist(users, username))
                {
                    //This foreach-loop prevents admins deletion
                    foreach (KeyValuePair<string, User> userlist in users.UserList)
                    {
                        User currentUser = userlist.Value;
                        string key = userlist.Key;
                        if (currentUser.Username == username)
                        {
                            //Checks if the user is admin, admin class has it set to true so if the user trying to get removed is admin you come here
                            if (currentUser.IsAdmin)
                            {
                                Console.WriteLine("Du får inte ta bort en admin!");
                                isRunning = false;
                            }
                            else
                            {
                                //If it's a customer then it gets removed
                                Thread.Sleep(1000);
                                users.DeleteCustomerInRegister(key);
                                isRunning = false;
                            }
                        }

                    }

                }
                else
                {
                    Console.WriteLine($"{username} finns inte. Försök igen!");
                    Thread.Sleep(1000);
                }
            }
        }

        public bool DoesUsernameExist(UserRegister users, string username)
        {
            //Help to check if username/password is unique when adding a customer, compare with already excisting in CustomerRegister
            //Checks if the dictionary contains the specified value Username
            //Goes through the dictionary to see if the userinput matches the username in UserList
            foreach (KeyValuePair<string, User> userlist in users.UserList)
            {
                User currentUser = userlist.Value;
                if (currentUser.Username == username)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
