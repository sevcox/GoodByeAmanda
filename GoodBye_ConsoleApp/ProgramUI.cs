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
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Amanda and the Basement Crew!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine(
                    "You made it to the last day! How? IDK but you did! \n" +
                    "Unfortunately, your last day isn't our last day but one thing's for sure... \n" +
                    "WE WILL MISS YOU! \n" +
                    "Below you will find a goodbye message from each of us. \n" +
                    "Type a number that corresponds with a student to see what we have to say!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                string userInput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Amanda,\n" +
                            "Thanks so much for all the knowledge you’ve passed on to us over the last eight weeks.It’s been awesome to see how far we’ve all come and we certainly couldn’t have done it without you and your infectious energy! Best of luck with your upcoming class, you will be missed greatly!");
                        Console.ReadLine();
                        break;
                    case "2":
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Thank you for being so patient with us. You have been an excellent teacher, motivator, and mentor. Sucks to see you go, but appreciative of what we got to learn from you. Take care, and good luck with everything you decide to do moving forward!");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Amanda, Thank you so much for being the encouraging and uplifting teacher you are. Class is always enjoyable with your ability to educate while spreading kindness and joy. You will be missed very much these next few weeks but go enjoy your time off!! (especially while sky diving)");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Amanda- Often we don't realize how greatly someone has affected our lives on a daily basis until they are no longer in our daily lives. Thankfully, you only were only sick for a week. It was enough to know how much I missed your daily non-stop energetic teaching style that filled my days with silliness and smiles.Your incredible ability to teach shined through the fun we had.  I wish you well in the new class- they will not know how lucky they are. We will miss you greatly!");
                        Console.ReadLine();
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Amanda – This class has been great with you as our teacher and leader. Your sense of humor and enthusiasm have made learning a very enjoyable experience. Enjoy your time “off” before your next class starts.");
                        string firstWord = "You";
                        string secondWord = "Will";
                        string thirdWord = "Be"; 
                        string fourthWord = "Missed!";
                        Console.WriteLine(firstWord);
                        Console.WriteLine(secondWord);
                        Console.WriteLine(thirdWord);
                        Console.WriteLine(fourthWord);
                        Console.ReadLine();
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Amanda!!! Man, I am really going to miss your engaging way of teaching, patience, and humor! Thank you so much for making my first experience with code something to remember. I would have never made it this far without you! Your ability to teach with such energy and radiance is really something special! You made a huge impact on me! \n" +
                            " I know this isn't a forever goodbye so I won't get too sentimental, but dang your next class is mighty lucky to have you! See you soon!");
                        Console.ReadLine();
                        break;
                    case "12":
                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine("Amanda- thank you for all that you have done. you have really made the class super enjoyable. It was really easy waking up every morning excited to go to class because of the energy that you brought everyday. Don’t think that I could have done it without your leadership and patience. Looking back 8 weeks ago to where I am now I really don’t think I could have done it without your leadership and patience! I wish nothing but the best for you! You will be greatly missed these next 4 weeks!");
                        Console.ReadLine();
                        break;
                    case "14":
                        break;
                    case "15":
                        Console.Clear();
                        Console.WriteLine("Will missing you on a daily basis, it was a pleasure having you as a teacher. The class will not be quite the same with you and the Basement Crew. Thanks for inspiring us to continue to push and learn more. You have taught us all so much. Good Luck with the next class hope they are just a bunch of good folks like this class was. Maybe when all this is over we can have a social distancing reunion at some point. And always remember The August Gloops!");
                        Console.ReadLine();
                        break;
                    case "16":
                        Console.Clear();
                        Console.WriteLine("We are going to miss you! Thanks for being such an awesome instructor! You really made an impact on all of us! Good-Bye & We Hope To See You Soon!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        string tfour = "///////////";
                        string five = " /////////";
                        string one = " ///   ///";
                        string seven = "   /////";
                        string six = "  ///////";
                        string two = "///// /////";
                        string eight = "    ///";
                        string nine = "     /";
                        Console.WriteLine(one);
                        Console.WriteLine(two);
                        Console.WriteLine(tfour);
                        Console.WriteLine(tfour);
                        Console.WriteLine(five);
                        Console.WriteLine(six);
                        Console.WriteLine(seven);
                        Console.WriteLine(eight);
                        Console.WriteLine(nine);
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Come on Amanda! We are trying to say goodbye! I am assuming your cat hit the wrong key! Choose a number between 1-16!");
                        break;

                }
            }
        }
    }
}
