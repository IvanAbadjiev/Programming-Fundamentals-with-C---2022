namespace P08._Beer_Kegs
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //read bear kegs 
            int n = int.Parse(Console.ReadLine());
            //varale to save date 
            double maxVolum = double.MinValue;
            string kagName = string.Empty;

            //read bear kegs volum n * 3 lines 
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                //calculate volum
                double currentVolum = Math.PI * Math.Pow(radius, 2) * height;

                //validate max volum
                if (currentVolum > maxVolum)
                {
                    maxVolum = currentVolum;
                    kagName = model;
                }

            }
            Console.WriteLine(kagName);




        }
    }
}
