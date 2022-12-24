using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace mathe_game
{
    class program
    {
        static bool PoseQuestion (int Min, int Max)
        {
            Random rand = new Random();
         int answerint = 0;
            int result = 0;
         while (true) 
            {
                int a = rand.Next(Min, Max + 1);
                int b = rand.Next(Min, Max + 1);
               Console.Write(a + " + " + b + "= ");
                string answer = Console.ReadLine();
                try
                {
                    answerint = int.Parse(answer);
                    result = a + b;
                    if (result == answerint)
                    {
                       return  true ;
                    }
                    return false ;
                }
                catch 
                {
                    Console.WriteLine("Erreur : you should give a number");
                }
              
            } // aswerint
        }
        static void Main(string[] args) 
        {
            const int Nb_Min = 1;
            const int Nb_Max = 10;
            const int Nb_Question = 3;
            int score = 0;  
            for (int i = 0;i < Nb_Question;i++)
            {
                Console.WriteLine("question number " + (i +1) + "/" + Nb_Question);    
                bool goodAnswer = PoseQuestion(Nb_Min, Nb_Max);
                if (goodAnswer)
                {
                    Console.WriteLine("good Answer");
                    score ++;
                }
                else
                {
                    Console.WriteLine("false Answer");
                }
            }
            Console.WriteLine("Your score is " + score + "/" + Nb_Question);
            
        
        }
    }
}
