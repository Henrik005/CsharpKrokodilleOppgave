using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpKrokodilleOppgave
{
    internal class Krokodille
    {
        
        private int points = 0;
        private string correctAnswer = "";
        public void Run()
        {

            Random random = new Random();
            var randomNr = random.Next(0, 11);
            var randomNr2 = random.Next(0, 11);

            
            Console.WriteLine($"{randomNr}_{randomNr2}");
            string input = Console.ReadLine();

            
            if (input == "<" || input == ">" || input == "=" )
            {
                if (randomNr > randomNr2)
                {
                    correctAnswer = ">";
                }
                else if (randomNr < randomNr2)
                {
                    correctAnswer = "<";
                }
                else
                {
                    correctAnswer = "=";
                }

                if (input == correctAnswer)
                {
                    points++;
                    Console.WriteLine($"Your Points: {points}");
                    Run();
                }
                else
                {
                    points--;
                    Console.WriteLine($"Your Points: {points}");
                    Run();
                }
            }
            else
            {
                System.Environment.Exit(0);
            }
           
        }
    }
}



