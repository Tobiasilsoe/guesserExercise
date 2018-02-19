using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 3;

        static void Main(string[] args)
        {
            /* TO DO: here is where you add your code! */
            int i = 0;
            string password;
            do
            {
                Console.WriteLine("Write your password here");
                password = Console.ReadLine();

                if (password == "kakao")
                {
                    Console.WriteLine("succes");
                    break;
                }
                else
                {
                    i++;
                    
                    if (i == MaxTrials)
                    {
                        Console.WriteLine("Max attempts tried. You cannot enter");
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Password failed, try again");
                }


            } while (i < MaxTrials);
            {
              
            }
            Console.ReadLine();
            //not exactly usefull, just to make it easier to read
        
        }
    }
}
