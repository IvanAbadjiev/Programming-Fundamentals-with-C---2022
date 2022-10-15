namespace P06._Calculate_Rectangle_Area
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double area = GetRectangleArea(w, h);
            Console.WriteLine(area);


        }

        static double GetRectangleArea(int w, int h)
        {
            double result = w * h;
            return result;

        }
    }
}
