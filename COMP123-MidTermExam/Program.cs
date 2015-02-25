using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    class Program
    {
        static void Main(string[] args)
        {
            /* NOTE: Add a menu to your program that reads the console.
             *  The menu will display a brief message to the user and 
             *  provide 3 choices:
             *  1. The first lotto game
             *  2. The second lotto game
             *  3. Exit
             */

            string choice = "";
            while(choice != "3")
            {
                
                Console.WriteLine("+++++++++++++++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("Key 1 for Lotto 649");
                Console.WriteLine("Key 2 for lotto Max");
                Console.WriteLine("Key 3 for exit");
                Console.WriteLine();
                Console.WriteLine("+++++++++++++++++++++++++++");
                switch(choice)
                {

                    case "3":
                        break;

                    case "1":
                        Console.WriteLine("Lets play Lotto 649");
                        Lotto649 myLotto = new Lotto649();
                        
                        choice = "";
                        break;

                    case "2":
                        Console.WriteLine("Lets play Lotto Max");
                        LottoMax LuckyLotto = new LottoMax();
                        
                        choice = "";
                        break;

                    default:
                        choice = CheckKey(choice);
                        break;
                }
            }



        }
        private static string CheckKey(string choice)
        {

            Console.WriteLine("Enter your choice");
            choice = Console.ReadLine();
            return choice;
        }
        

    }
}
