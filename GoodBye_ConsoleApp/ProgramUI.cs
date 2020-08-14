using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBye_ConsoleApp
{
   public class ProgramUI
    {
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Amanda and the Basement Crew! \n" +
                    "You made it to the last day! How? IDK but you did! \n" +
                    "Unfortunately, your last day isn't our last day but one thing's for sure... \n" +
                    "WE WILL MISS YOU! \n" +
                    "Below you will find a goodbye message from each of us. Type the number to see what we have to say! \n" +
                    "1. Adam Schulz \n" +
                    "2. AJ Sheehand \n" +
                    "3. Austin Hooker \n" +
                    "4. Jack McCoy \n" +
                    "5. Jeff Beeson \n" +
                    "6. Jeff Richardson \n" +
                    "7. Kaleb Emery \n" +
                    "8. Kristopher Prater \n" +
                    "9. Lisa Jeffers \n" +
                    "10. Nick Davies \n" +
                    "11. Severa Cox \n" +
                    "12. Tim Culp \n" +
                    "13. Tyler Klink \n" +
                    "14. Xavier Collins \n" +
                    "15. Zachary Sperka \n" +
                    "16. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    case "11":
                        break;
                    case "12":
                        break;
                    case "13":
                        break;
                    case "14":
                        break;
                    case "15":
                        break;
                    case "16":
                        Console.WriteLine("We are going to miss you! Thanks for being an awesome instructor! Good Bye and See You Soon!");
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Come on Amanda! We are trying to say good bye! I am assuming your cat hit the wrong key! Choose a number between 1-16!");
                        break;

                }
            }
        }
    }
}
