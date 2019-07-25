using System;
using System.Collections.Generic;
using scrabble;



namespace frontEnd
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("input a word to find your scrabble score");
            string userInput= Console.ReadLine().ToUpper();

            Item newItem = new Item();
            
               int FinalScore = newItem.Score(userInput);
               Console.WriteLine("Your Total score is {0}", FinalScore);
                
        }
    }
}