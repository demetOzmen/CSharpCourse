// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!")
namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            //Value Types 
            byte number4 = 255;          // 8 bit
            short number3 = 32767;       // 16 bit
            int number1 = 1000000000;    // 32 bit
            long number2 = 10000000000;  // 64 bit
            bool condition = false;      // true false
            char character = 'a';        // karakter
            double number5 = 0.5;        //ondalık virgülden sonra 15 16 kar.
            decimal number6 = 10.4m;     // virgülden sonra 24 kar
            var number7 = 10;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number1 is {0}", number2);
            Console.WriteLine("Number1 is {0}", number3);
            Console.WriteLine("Number1 is {0}", number4);
            Console.WriteLine(condition);
            Console.WriteLine("character is :{0}", (int)character);
            Console.WriteLine("Number1 is {0}", number5);
            Console.WriteLine((int)Days.friday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        monday, tuesday, wednesday, thursday, friday, saturday, sunday
    }
}