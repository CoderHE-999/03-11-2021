using System;
using System.Collections.Generic;
using System.Text;

namespace _03_11_2021
{
    class PasswordIncorrectException:Exception
    {

        public PasswordIncorrectException(string? msg) : base(msg)
        {

        }
    }
}
