using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Game");
            DefaultBoard();
            CurrentBoardState();
        
        }
        
        static void DefaultBoard()
        // Method to create a tic tac toe board that shows player what number represents which square
        // Spend way to much time on this section and over thought it
        // Plus too pretty to start over
        {
            int squareNum = 1;
            // string topLine = " _ _ _ ";
            // string spacer = "|     |";
            // string spacerNumber = "|  {0}  |";
            // string lastLine = "|_ _ _|";
             
            for (int i = 0; i < 3; i++)
            // Loop to create three rows
            {
                for (int j = 0; j < 3; j++)
                // Loop to create three columns in each row
                {
                    Console.Write(" _ _ _ ");
                    // Use Write so that it doesn't use line terminator
                }
                // Need a new line after 
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)    
                {
                    Console.Write("|     |");
                }    
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)    
                {
                    Console.Write("|  {0}  |", squareNum);
                    squareNum++;
                }    
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|_ _ _|");
                }
                Console.WriteLine("");
            }
        }
        static void CurrentBoardState()
        {
            Console.WriteLine("Hello, World");
        }

    
    }
}


