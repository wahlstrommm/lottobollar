using System;

namespace LottobollA
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] userTal = new int[10]; //vektor användartal med 10 st "platser"
            int[] slump_tal = new int[2]; // vektor som slumpar fram två tal
            
            Random randomerare = new Random(); //randomerare
            for(int i = 0; i < slump_tal.Length; i++) // for loop för slumptal
            {
               slump_tal[i] = randomerare.Next(1, 26); // tar fram två st slumptal mellan 1-25.
            }


            Console.WriteLine("Hej börja skriv in 10 tal mellan 1-25!");
            for (int i = 0; i < userTal.Length; i++) //for loop för användartalen
            {

                userTal[i] = Convert.ToInt32(Console.ReadLine()); 

                if (userTal[i] < 0 || userTal[i] > 25) //om det håller sig inom 0-25 så läggs ett "val" av lottoboll till på användare om inte får de skriva in ett nytt tal
                {
                    i--;
                }

            }

            int raknare = 0; //räknare som håller koll på hur många gånger användare har haft rätt   
            for (int i = 0; i < userTal.Length; i++)
            {
                for (int j = 0;  j < slump_tal.Length; j++)
                {
                    if (userTal[i] == slump_tal[j])
                    {
                        raknare++; //ökar med 1.
                    }
                }  
            }
            
            if (raknare == slump_tal.Length) // om räknaren är lika som slumptal.length alltså i detta fall får man bingo.
            {
                Console.WriteLine("Bingo!");
            }
            else
            {
                Console.WriteLine("Du hade " + raknare + " rätt!"); //skriver ut hur många rätt man har fått.
            }

            Console.Write("Lottonumren var: " );
            for (int i = 0; i < slump_tal.Length; i++) 
            {
                Console.Write(slump_tal[i] + " ");//kommer skriva ut lottonummerna.
            }
            Console.Write("\n"); //ny rad  (new line)

        }
    }
}
