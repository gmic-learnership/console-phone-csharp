using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class PhoneClass
    {
        public string phone_number;

        public string RemoveCharacters(string phone_number)
        {
            if (phone_number.Contains("(") || phone_number.Contains(")") || phone_number.Contains("-") || phone_number.Contains(" "))
            {

                phone_number = phone_number.Replace("(", "");
                phone_number = phone_number.Replace(")", "");
                phone_number = phone_number.Replace("-", "");
                phone_number = phone_number.Replace(" ", "");

            }

            return phone_number;
        }

        public void CloseApp(string phone_num)
        {
            while (phone_num == "")
            {
                Console.WriteLine("Please enter a telephone number: ");
                phone_num = Console.ReadLine();
            }

            while (phone_num == "exit")
            {
                Console.WriteLine("\n\t\tGoodbye :)");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
        }

        public string checkFirst3Numbers(string phone_num)
        {
            string temp = phone_num.Substring(0, 3);


            if (temp == "012" || temp == "011" || temp == "083" || temp == "072" || temp == "069" || temp == "073")
            {

                checkPhonebook(phone_num);
            }
            else
            {
                Console.WriteLine("\nSorry this number is invalid :( , please try to enter the number again\n");
                Console.WriteLine("================================================\n");
            }
            return phone_num;
        }

        public string checkPhonebook(string phone_num)
        {
            string Funi = "0726070685";
            string Tinyiko = "0737397153";
            string Prudence = "0720751453";
            string DVT = "0117595930";

            if (phone_num.CompareTo(Funi) == 0)
            {
                Console.WriteLine("\nYour number is valid. Please hold while we dial");
                Console.WriteLine("Dialing Funi ...\n...\n...");
                Console.WriteLine("Successfully dialed Funi");
            }

            else if (phone_num.CompareTo(Tinyiko) == 0)
            {
                Console.WriteLine("\nYour number is valid. Please hold while we dial");
                Console.WriteLine("Dialing Tinyiko ...\n...\n...");
                Console.WriteLine("Successfully dialed Tinyiko");
            }
            else if (phone_num.CompareTo(DVT) == 0)
            {
                Console.WriteLine("\nYour number is valid. Please hold while we dial");
                Console.WriteLine("Dialing DVT ...\n...\n...");
                Console.WriteLine("Successfully dialed DVT");
            }
            else if (phone_num.CompareTo(Prudence) == 0)
            {
                Console.WriteLine("\nYour number is valid. Please hold while we dial");
                Console.WriteLine("Dialing Prudence ...\n...\n...");
                Console.WriteLine("Successfully dialed Prudence");
            }
            else

            {
                Console.WriteLine("\nYour number is valid. Please hold while we dial");
                Console.WriteLine("Dialing " + phone_num + " ...\n...\n...");
                Console.WriteLine("Successfully dialed " + phone_num);
            }
            return phone_num;
        }

        public void ValidateNumericValues()
        {
            try
            {
                int temp = Convert.ToInt32(phone_number);
            }
            catch (Exception e)
            {

                Console.WriteLine("\nSorry, the number you entered is incorrect.");
                Console.WriteLine("Please enter a valid, numeric telephone number\n", e);
                Console.WriteLine("-------------------------------------------");
                phone_number = Console.ReadLine();

            }
        }
    }
}




