using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneClass tel = new PhoneClass();
            string phone_number;
           
            Console.WriteLine("\t\tWelcome to our telephone program");
            Console.WriteLine("\t\t--------------------------------");
            Console.WriteLine();

            Console.WriteLine("Please enter a telephone number: ");
            phone_number = Console.ReadLine();

            tel.CloseApp(phone_number);

            Console.WriteLine("\nThe phone number you entered is " + phone_number + "\n");

            //this for loop iterates through the characters of the phone number then strips it of separation characters

            do
            {
                for (int i = 1; i < phone_number.Length; i++)

                {
                   phone_number = tel.RemoveCharacters(phone_number);
                }

                tel.ValidateNumericValues();

                //this loop checks if the number is avalid 10 digit number then calls a method to check 
                // if its a number that falls in the list: 011, 012, 072, 083, 073, 069

                if (phone_number.Length == 10)
                {
                   phone_number = tel.checkFirst3Numbers(phone_number);
                }
                else
                {
                    Console.WriteLine("\nSorry, you have entered an invalid number");
                    Console.WriteLine("Please check your number and enter it again:(");
                    Console.WriteLine("--------------------------------------------");
                    
                }
                Console.WriteLine("\nThanx for using our telephone service\n\nType 'exit' to exit or enter another number:");
                Console.WriteLine("================================================\n");
                phone_number = Console.ReadLine();
                tel.CloseApp(phone_number);
            
            } while (phone_number != "exit");
        }
    }
}
