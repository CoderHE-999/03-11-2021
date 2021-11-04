using System;

namespace CheckPassword
{
    public class Check
    {
        public bool hasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool hasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool hasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
