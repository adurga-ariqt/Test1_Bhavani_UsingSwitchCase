using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Bhavani_UsingSwitchCase
{
    public class Colors
    {
        public void ColorsMethod()
        {
            String letter;
            Console.WriteLine("Enter Letter from the VIBGYOR:");
            letter = Console.ReadLine();
            switch (letter)
            { case "v":
                    Console.WriteLine("Violet");
                    break;
               case "I":
                    Console.WriteLine("Indigo color");
                    break;
                case "B":
                    Console.WriteLine("Blue Color");
                    break;
                case "G":
                    Console.WriteLine("Green Color");
                    break;
                case "Y":
                    Console.WriteLine("Yellow colour");
                    break;
                case "O":
                    Console.WriteLine("Orange Colour");
                    break;
                case "R":
                    Console.WriteLine("Red Colour");
                    break;
                default:
                    Console.WriteLine("Not a colour from VIBGYOR");
                    break;

            }


        }    
    }
}
