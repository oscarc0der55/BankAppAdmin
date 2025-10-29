using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    internal class InputValidation
    {
        public static string TrimmedString()
        {
            string value = "";
            bool stillValidating = true;
            while (stillValidating)
            {
                string? userInput = Console.ReadLine();
                //Trims the string if the string isn't empty or a " " string
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    value = userInput.Trim();
                    value = value.ToLower();
                    stillValidating = false;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Välj rätt input, försök igen!");
                }
            }

            return value;
        }
    }
}
