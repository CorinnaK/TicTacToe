using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] board = {{" ","X", " "},{" "," "," "},{" "," ", " "}}; 
            Console.WriteLine("Welcome to the Tic Tac Toe Game");
            DefaultBoard("default", board);
            Console.WriteLine("This is the current state with 1 marked as x");
            DefaultBoard("current", board);
            CurrentBoardState();
        
        }
        
        static void DefaultBoard(string state, string[,] currentArray)
        // Method to create a tic tac toe board that shows player what number represents which square
        // Spend way to much time on this section and over thought it
        {   
           
            if (state == "default")
            {
                Console.WriteLine("Here is the default board marking the spaces with the number representation");
                string [,] squareArr = {{"0","1", "2"},{"3","4","5"},{"6","7", "8"}};                      
                Console.WriteLine("\n      |       |        ");
                Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[0,0], squareArr[0,1], squareArr[0,2]);
                Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
                Console.WriteLine("      |       |        ");
                Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[1,0], squareArr[1,1], squareArr[1,2]);
                Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
                Console.WriteLine("      |       |        ");
                Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[2,0], squareArr[2,1], squareArr[2,2]);
                Console.WriteLine("      |       |        \n");
                
            }
            else
            {
                string [,] squareArr = currentArray;
                Console.WriteLine("\n      |       |        ");
                Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[0,0], squareArr[0,1], squareArr[0,2]);
                Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
                Console.WriteLine("      |       |        ");
                Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[1,0], squareArr[1,1], squareArr[1,2]);
                Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
                Console.WriteLine("      |       |        ");
                Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[2,0], squareArr[2,1], squareArr[2,2]);
                Console.WriteLine("      |       |        \n");                         
            }
        }     

        static void CurrentBoardState()
        {
            Console.WriteLine("Hello, World");
        }

    
    }
}


