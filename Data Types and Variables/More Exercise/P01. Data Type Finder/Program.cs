namespace P01._Data_Type_Finder
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            string dataType = Console.ReadLine();


            while (dataType != "END")
            {
                //validate int  
                int numberIsInt = 0;
                bool data = int.TryParse(dataType, out numberIsInt);
                //validate Floting point
                double numberIsdouble = 0;
                bool data2 = double.TryParse(dataType, out numberIsdouble);
                //validate char
                char numberIschar;
                bool data3 = char.TryParse(dataType, out numberIschar);
                //validate bool
                bool numberIsbool;
                bool data4 = bool.TryParse(dataType, out numberIsbool);
                //validate string
                // string numberIsstring;
                // bool data5 = string.TryParse(dataType, out numberIsstring);

                if (data)
                {
                    Console.WriteLine($"{dataType} is integer type");
                }
                else if (data2)
                {
                    Console.WriteLine($"{dataType} is floating point type");
                }
                else if (data3)
                {
                    Console.WriteLine($"{dataType} is character type");
                }
                else if (data4)
                {
                    Console.WriteLine($"{dataType} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{dataType} is string type");
                }

                dataType = Console.ReadLine();
            }

        }
    }
}
