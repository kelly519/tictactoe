using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            char f1, f2, f3, f4, f5, f6, f7, f8, f9;



            Console.WriteLine("What's the state of the first field: ");
            f1 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f2 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f3 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f4 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f5 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f6 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f7 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f8 = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What's the state of the first field: ");
            f9 = Console.ReadLine().ToUpper()[0];


            if (f1 != 'X'! && f1 != '0')
                f1 = ' ';
            if (f2 != 'X'! && f2 != '0')
                f2 = ' ';
            if (f3 != 'X'! && f3 != '0')
                f3 = ' ';
            if (f4 != 'X'! && f4 != '0')
                f4 = ' ';
            if (f5 != 'X'! && f5 != '0')
                f5 = ' ';
            if (f6 != 'X'! && f6 != '0')
                f6 = ' ';
            if (f7 != 'X'! && f7 != '0')
                f7 = ' ';
            if (f8 != 'X'! && f8 != '0')
                f8 = ' ';
            if (f9 != 'X'! && f9 != '0')
                f9 = ' ';


            Console.WriteLine($" {f1} | {f2}  | {f3} \n"
                             + "---+---+---\n"
                             + $" {f4} | {f5}  | {f6} \n"
                             + "---+---+---\n"
                             + $" {f7} | {f8}  | {f9} ");// +(char)9553 + (int) '|' + " " + (char)65 + (char)('a" -32));





        }
    }
}
