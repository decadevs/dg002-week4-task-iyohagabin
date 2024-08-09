using bankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApp.Services
{
    public class CustomerService
    {
        private List<Customer> customers = new List<Customer>();

        public List<Char> allowedPasswordsymbols = new List<Char>()
        {
            '@', '#', '$', '%', '^', '&', '!'
        };
        public CustomerService() { }

        public string CustomerValidation(string firstName, string lastName, string email, string password)
        {
            if (string.IsNullOrEmpty(firstName) || Char.IsDigit(firstName[0]) || Char.IsLower(firstName[0]))
            {
                return "FirstName must start with an uppercase letter and must not start with a digit.";
            }

            if (string.IsNullOrEmpty(lastName) || Char.IsDigit(lastName[0]) || Char.IsLower(lastName[0]))
            {
                return "LastName must start with an uppercase letter and must not start with a digit.";
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                return "Email must be in a valid format (e.g., name@example.com).";
            }

            if (string.IsNullOrEmpty(password) || password.Length < 6 || password.IndexOfAny(allowedPasswordsymbols.ToArray()) != -1) 
            {
                return "Password must be at least 6 characters long, include alphanumeric characters, and at least one special character (@, #, $, %, ^, &, !).";
            }
        }
   
    }
}
