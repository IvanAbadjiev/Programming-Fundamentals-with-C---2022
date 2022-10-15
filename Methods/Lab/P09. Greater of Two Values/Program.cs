namespace P09._Greater_of_Two_Values
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            GetMax(type);

        }

        static void GetMax(string type)
        {
            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    if (a > b)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(b);
                    }
                    break;
                case "char":
                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());
                    if (c > d)
                    {
                        Console.WriteLine(c);
                    }
                    else
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "string":
                    string m = Console.ReadLine();
                    string f = Console.ReadLine();
                    int representM = 0;
                    int representF = 0;
                    for (int i = 0; i < f.Length; i++)
                    {
                        representM += (int)m[i];
                        representF += (int)f[i];

                    }


                    if (representM > representF)
                    {
                        Console.WriteLine(m);
                    }
                    else
                    {
                        Console.WriteLine(f);
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
