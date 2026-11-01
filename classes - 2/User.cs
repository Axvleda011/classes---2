using System;
using System.Collections.Generic;
using System.Text;

namespace classes___2
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _email;
        private string _password;
        private string _phoneNumber;
        private string _username;
        private string _personalNumber;
        private decimal _balance;
        private DateTime _birthDate;

        
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("First name must contain at least 2 characters.");

                _firstName = value;
            }
        }

        
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Last name must contain at least 2 characters.");

                _lastName = value;
            }
        }

        
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 120)
                    throw new ArgumentException("Age must be between 18 and 120.");

                _age = value;
            }
        }

        
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
                    throw new ArgumentException("Invalid email address.");

                _email = value;
            }
        }

        
        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 8)
                    throw new ArgumentException("Password must contain at least 8 characters.");

                _password = value;
            }
        }

        
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9)
                    throw new ArgumentException("Phone number must contain exactly 9 digits.");

                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                        throw new ArgumentException("Phone number must contain only digits.");
                }

                _phoneNumber = value;
            }
        }

        
        public string Username
        {
            get { return _username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                    throw new ArgumentException("Username must contain at least 4 characters.");

                _username = value;
            }
        }

        
        public string PersonalNumber
        {
            get { return _personalNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 11)
                    throw new ArgumentException("Personal number must contain exactly 11 digits.");

                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                        throw new ArgumentException("Personal number must contain only digits.");
                }

                _personalNumber = value;
            }
        }

        
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative.");

                _balance = value;
            }
        }

        
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value >= DateTime.Now || value < DateTime.Now.AddYears(-120))
                    throw new ArgumentException("Invalid birth date.");

                _birthDate = value;
            }
        }
    }
}
