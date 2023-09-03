using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class SwitchCases
    {
       public void Switchloop()
        {

            Console.WriteLine("Hello Welcome to Our Coffee Shop ^_^");

            int Total = 0;

        again:  //Label For the Goto Statement

            Console.WriteLine("\nPlease let us know What do u want to order!!! \n1) Cold Coffee\n2)Hot Coffee\n3)Ginger Tea ");
            Console.WriteLine("\nPlease Enter Your Choice");

            string Choice = Console.ReadLine();
            int trychoice;
            int.TryParse(Choice, out trychoice);

            switch (trychoice)
            {
                case 1:
                    Console.WriteLine("\nYou Have orderd a Cold Coffe... ^_^\n");
                    Total += 30;
                    break;
                case 2:
                    Console.WriteLine("\nYou Have orderd a Hot Coffe... ^_^\n");
                    Total += 20;
                    break;
                case 3:
                    Console.WriteLine("\nYou Have orderd a Ginger Tea... ^_^\n");
                    Total += 10;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter a valid choice sir!!!");
                    goto again;
            }
            Console.WriteLine("\nDo u want to order some more\nY for Yes\nN for no");

            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());


            switch (ch)
            {
                case 'Y':
                case 'y':
                    goto again;
                case 'n':
                case 'N':
                    Console.WriteLine($"Your fial bill is : Rs{Total}");
                    Console.WriteLine("Thank you for shoppin with us \nplease visit us again ^_^");
                    break;
            }

        }

    }
}
