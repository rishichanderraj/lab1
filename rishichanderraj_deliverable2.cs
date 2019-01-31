using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userAnswers = new string[3];
            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill Times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");

            int entry1 = Convert.ToInt16(Console.ReadLine());
         
             switch (entry1)
                {
                    case 1:
                        userAnswers[0] = "action";
                        userAnswers[1] = "go stock car racing";
                        break;
                    case 2:
                        userAnswers[0] = "chill times";
                        userAnswers[1] = "go hiking";
                        break;
                    case 3:
                        userAnswers[0] = "danger";
                        userAnswers[1] = "skydiving";
                        break;
                    case 4:
                        userAnswers[0] = "good food";
                        userAnswers[1] = "go to Taco Bell";
                        break;
                    default:
                        Console.WriteLine("I didn't understand your response");
                        break;
                }
                Console.WriteLine("How many people are you bringing with you?");
                int entry2 = Convert.ToInt16(Console.ReadLine());

                switch (entry2)
                {
                    case int n when (n < 1):
                        userAnswers[2] = "some sneakers";
                        break;
                    case int n when (n >= 1 && n < 5):
                        userAnswers[2] = "a sedan";
                        break;
                    case int n when (n >= 5 && n <= 10):
                        userAnswers[2] = "a Volkswagen bus";
                        break;
                    case int n when (n >= 11):
                        userAnswers[2] = "an airplane";
                        break;
                    default:
                        Console.WriteLine("I didn't understand your response");
                        break;
                }
            if (userAnswers[0] == null || userAnswers[2] == null)
            {
                Console.WriteLine("The program didn't understand your responses, you'll have to try again");
            }
            else
            {
                Console.WriteLine("Okay!  If you're in the mood for {0} then you should {1} and travel in {2}", userAnswers[0], userAnswers[1], userAnswers[2]);
                Console.WriteLine("Goodbye");
            }
        }
    }
}
