using System;
using System.Collections.Generic;
using System.Text;
using CheckPassword;

namespace _03_11_2021
{
    class User
    {

        public User(string username)
        {
            this._userName = username;
        }

        public User(string username, string password)
        {
            this._userName = username;
            this._password = password;
        }

        private string _userName;
        private string _password;

        public string UserName {
            get => _userName;
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    this._userName = value;
                }

                else
                {
                    throw new InvalidUserNameException("Ad duzgun deyil!");
                }
            }
        }

        Check check = new Check();
        public string Password {
            get => _password;
            set
            {
                if ((value.Length >= 8 && value.Length <= 25) && !string.IsNullOrWhiteSpace(value) && check.hasDigit(value) && check.hasLower(value) && check.hasUpper(value))
                {
                    this._password = value;
                }

                else
                {
                    throw new PasswordIncorrectException("Sifre duzgun deyil!");
                }
                
            }
        }
    }
}
