using System;
using System.Collections.Generic;
using System.Text;

namespace _03_11_2021
{
    class InvalidUserNameException:Exception
    {
 

        public InvalidUserNameException(string? msg) : base(msg)
        {

        }
    }
}
