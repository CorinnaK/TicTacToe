using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] instructionBoard = {{"0","1", "2"},{"3","4","5"},{"6","7", "8"}};
            string [,] currentBoard = {{" "," ", " "},{" "," "," "},{" "," ", " "}};
            string currentPlayer = "X";
            // Source https://www.exploratorium.edu/brain_explorer/tictactoe.html
            // Copied the rules for Tic Tac Toe for readability and understanding
            string instructions = "The game is played on a grid that's 3 squares by 3 squares. The first player is X and the second is O. \nPlayers take turns selecting a square to put their marks in.The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner. \nWhen all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie. \n";
            string winner = "playOn";
            // while (winner == "playOn")
            // {}
            Console.WriteLine(instructions);
            PrintGameBoard(instructionBoard);
            Console.WriteLine("Please note that all the squares are numbered to their corresponding location. \nTo make your move please type the number of an empty square you would like to put your mark in when prompted on your turn. \nThe board will refresh after each turn. \n \nCurrent Board in Play");
            PrintGameBoard(currentBoard);
            Console.WriteLine("Player {0}, it is your turn. Please select an empty square: ", currentPlayer );

            // repeat while win codition not met -- PlayOn
            // Print instruction board !
            // Print Which Players turn
            // Print Current CurrentBoard
            // Print Prompt to User
            // Retrieve User play
            // Update board
            // Check for winner
            // Switch player
            // Clear terminal
        
            
            // Console.WriteLine(currentPlayer);
             
            // while (true)
            // Console.WriteLine("Welcome to the Tic Tac Toe Game \n It is Player X goes first");
            // DefaultBoard(instructionArray);
            // Console.WriteLine("This is the current state with 1 marked as x");
            // DefaultBoard(board);
            // currentPlayer = ChangePlayer(currentPlayer);
            // CurrentBoardState();
            // Console.Write("Player {0}", currentPlayer);
        
        }
        
        static void PrintGameBoard(string [,] currentArray)
        // Method to create a tic tac toe board that shows player what number represents which square
        // Spend way to much time on this section and over thought it with nested loops. In the end just used consoel write.
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
            // if (type == "instruction")
            // {
            //     Console.WriteLine("Here is the default board marking the spaces with the number representation");
            //     string [,] squareArr = {{"0","1", "2"},{"3","4","5"},{"6","7", "8"}};                      
            //     Console.WriteLine("\n      |       |        ");
            //     Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[0,0], squareArr[0,1], squareArr[0,2]);
            //     Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
            //     Console.WriteLine("      |       |        ");
            //     Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[1,0], squareArr[1,1], squareArr[1,2]);
            //     Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
            //     Console.WriteLine("      |       |        ");
            //     Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[2,0], squareArr[2,1], squareArr[2,2]);
            //     Console.WriteLine("      |       |        \n");
                
            // }
            // else
            // {
            //     string [,] squareArr = currentArray;
            //     Console.WriteLine("\n      |       |        ");
            //     Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[0,0], squareArr[0,1], squareArr[0,2]);
            //     Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
            //     Console.WriteLine("      |       |        ");
            //     Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[1,0], squareArr[1,1], squareArr[1,2]);
            //     Console.WriteLine("_ _ _ | _ _ _ | _ _ _  ");
            //     Console.WriteLine("      |       |        ");
            //     Console.WriteLine("  {0}   |   {1}   |   {2}    ", squareArr[2,0], squareArr[2,1], squareArr[2,2]);
            //     Console.WriteLine("      |       |        \n");                         
            // }
        }     

        static void CurrentBoardState()
        {
            Console.WriteLine("Hello, World");
        }
        static string ChangePlayer(string currentPlayer)
        {
            if (currentPlayer == "X")
            {
                return "O";
            }
            return "X";
        }

        static string CheckForWinningCombination( string[,] currentArray)
        {
            string winner = "Player X";
            return winner;
        } 
    
    }
}


