using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static int ask_number(int min,int max)
        {
            int user_number = min -1;
            while ((user_number < min) || (user_number > max))
            {
                Console.Write("Give a number betwen " + min + " and " + max + ": ");
                string answer = Console.ReadLine();
                try
                {
                    user_number = int.Parse(answer);
                    if ((user_number < min) || (user_number > max))
                    {
                        Console.WriteLine("Error,the number must be betwen " + min + "and " + max + ":");
                    }
                }

                catch
                {
                    Console.WriteLine("Error, enter a valid number");
                }
            
            }
            return user_number;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            const int nbrmin = 1;
            const int nbrmax = 10;
            int magic_nb = rand.Next(nbrmin, nbrmax + 1);
            
               int number = magic_nb + 1;
               // int nblife = 4;
             // while  (nblife > 0)
             for (int nblife = 4; nblife >0; nblife--) 
              {
                Console.WriteLine();
                Console.WriteLine("You have " + nblife + " chance");
                number = ask_number(nbrmin, nbrmax);
                    
               //Console.WriteLine("guess a number betwean " + nbrmin + "and" + nbrmax);
               //string guess_nbrs = Console.ReadLine();
               //guess_nbr = int.Parse(guess_nbrs);
                 if (magic_nb < number)
                 {
                  Console.WriteLine("this number is more big then the magic number");
                 }
                 else if (magic_nb > number)
                 {
                 Console.WriteLine("this number is more less then the magic number");                  
                 }
                 else
                 {
                    Console.WriteLine("Good Job ! Your number is: " + magic_nb);
                    break;
                 }
               // nblife--;

              }
              if (magic_nb != number)
              { 
                Console.WriteLine("You lose! the Magic Number is " + magic_nb);
              }

        }

      
    }
}