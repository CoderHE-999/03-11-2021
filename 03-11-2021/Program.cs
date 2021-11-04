using System;
using CheckPassword;


namespace _03_11_2021
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ad daxil edin:");
                string userName = Console.ReadLine();
                User users = new User(userName);
                Console.Write("Sifreni daxil edin: ");
                string password = Console.ReadLine();
                User users2 = new User(userName, password);

            }
            catch (InvalidUserNameException e)
            {
                Console.WriteLine(e.Message);
                
            }

            catch (PasswordIncorrectException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception)
            {
                Console.WriteLine("Bilinmeyen xeta bas verdi!");
            }

        }


        





    }
}
