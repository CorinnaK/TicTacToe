using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Game");
            CreateSquare();
        
        }
        static void CreateSquare()
        {
            string a = " _ _ _";
            string b = "|     |";
            string c = "|  1  |";
            string d = "|_ _ _|";
            Console.WriteLine(a + a + a);
            Console.WriteLine(b + b + b);
            Console.WriteLine(c + c + c);
            Console.WriteLine(d + d + d);
        }
    }
}
