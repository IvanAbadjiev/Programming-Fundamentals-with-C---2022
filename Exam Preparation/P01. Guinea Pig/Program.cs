namespace P01._Guinea_Pig
{
using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine()); 
            decimal hey = decimal.Parse(Console.ReadLine()); 
            decimal cover = decimal.Parse(Console.ReadLine()); 
            decimal weigth = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                food -= 0.3m;

                if (i % 2 == 0)
                {
                    hey -= food * 0.05m;
                }
                if (i % 3 == 0)
                {
                    cover -= weigth / 3;
                }

                if (cover <= 0 || hey <= 0 || food <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }

            if (cover > 0 && hey > 0 && food > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hey:f2}, Cover: {cover:f2}."
);
            }

            
            

           
        }
    }
}
