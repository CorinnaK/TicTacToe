using System;
using System.Collections.Generic;
using System.Threading;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            string [,] instructionBoard = {{"0","1","2"},{"3","4","5"},{"6","7","8"}};
            //defaultBoard = {{" "," ", " "},{" "," "," "},{" "," ", " "}};
            string currentPlayer = "X";
            // Source https://www.exploratorium.edu/brain_explorer/tictactoe.html
            // Copied the rules for Tic Tac Toe for readability and user understanding
            string instructions1 = "The game is played on a grid that's 3 squares by 3 squares. The first player is X and the second is O. \nPlayers take turns selecting a square to put their marks in.The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner. \nWhen all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends with the CAT winning (a draw or tie). \n";
            string instructions2 = "Please note that all the squares are numbered to their corresponding location. \nTo make your move please type the number of an empty square you would like to put your mark in when prompted on your turn. \nThe board will refresh after each turn. \n \nCurrent Board in Play";
            string gameState = "playOn";
            // Create a 2D array board with a space to maintain the visual of the drawn board 
            string[,] currentBoard = {{ " ", " ", " " },{ " ", " ", " " },{ " ", " ", " " }};
            while (gameState != "DONE")
            {
                if (gameState == "RESET")
                {
                    currentBoard = new string [,] { { " ", " ", " " },{ " ", " ", " " },{ " ", " ", " " } };
                }
                Console.WriteLine(instructions1);
                PrintGameBoard(instructionBoard);
                Console.WriteLine(instructions2);
                PrintGameBoard(currentBoard);
                Console.WriteLine("Player {0}, it is your turn. Please select an empty square: ", currentPlayer );
                string userSelection = Console.ReadLine();
                currentBoard = PlayGame(userSelection, currentBoard, currentPlayer);
                Console.WriteLine("Successful selection made");
                // @ Source https://www.tutorialspoint.com/Chash-Program-to-Pause-a-Thread#:~:text=C%23%20Program%20to%20Pause%20a%20Thread.%20To%20pause,set%20the%20sleep%20method%20to%20pause%20the%20thread.
                // Needed for user experience to pause so the message would display long enough to read parameter is in milliseconds
                Thread.Sleep(500); // Pause here please for a few seconds                
                gameState = CheckForWinningCombination(currentBoard, currentPlayer);
                currentPlayer = ChangePlayer(currentPlayer);
                Console.WriteLine("Test");
                
                Console.Clear();
            }            
        }
        
        static void PrintGameBoard(string [,] currentArray)
        // Method to create a tic tac toe board that shows player what number represents which square
        // Spend way to much time on this section and over thought it with nested loops. In the end just used console write.
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

        static string ChangePlayer(string currentPlayer)
        {
            if (currentPlayer == "X")
            {
                return "O";
            }
            return "X";
        }

        static string CheckForWinningCombination( string[,] currentArray, string currentPlayer)
        {
            // Winning rows are 012, 345, 678 column are 036, 147, 258, horizontal 048, 246 but not if they are just a space
            if (currentArray[0,0]==currentArray[0,1] && currentArray[0,2] == currentArray[0,1] && currentArray[0,0] != " "||
            currentArray[1,0]==currentArray[1,1] && currentArray[1,2] == currentArray[1,0] && currentArray[1,0] != " " ||
            currentArray[2,0]==currentArray[2,1] && currentArray[2,2] == currentArray[2,0] && currentArray[2,0] != " " ||
            currentArray[0,0]==currentArray[1,0] && currentArray[2,0] == currentArray[0,0] && currentArray[0,0] != " " ||
            currentArray[0,1]==currentArray[1,1] && currentArray[2,1] == currentArray[0,1] && currentArray[0,1] != " " ||
            currentArray[0,2]==currentArray[1,2] && currentArray[2,2] == currentArray[0,2] && currentArray[0,2] != " " ||
            currentArray[0,0]==currentArray[1,1] && currentArray[2,2] == currentArray[0,0] && currentArray[0,0] != " " ||
            currentArray[0,2]==currentArray[1,1] && currentArray[2,0] == currentArray[0,2] && currentArray[0,2] != " ")
            {
                Conole.Clear();
                PrintGameBoard(currentArray);
                Console.WriteLine("Congratulations!!!");
                Console.WriteLine(Art(currentPlayer));
                Console.WriteLine("You are the Winner");
                return PlayAgain();      
            }
            // Checking each square in the array to see if it the board is full
            for (int i = 0; i < currentArray.GetLength(0); i++)
                {
                    for (int j = 0; j < currentArray.GetLength(1); j++)
                    {
                        if (currentArray[i,j] == " ")
                        {
                            return "PlayOn";
                        }
                    }
                }
            Console.Clear();    
            PrintGameBoard(currentArray);    
            Console.WriteLine(" It is a Draw! The CAT has won --- Meow!");
            Console.WriteLine(Art("draw"));
            return PlayAgain();
        }
        static string[,] PlayGame (string userSelection, string[,] currentArray, string currentPlayer)
        // Method to check the users selection for validity - valid unoccupied square and square number
        {
            // Start of error checking. Adapated from Class.
            int userSquareSelection = 10;
            while (true)
            {
                try
                // First check to see if it is an integer
                {
                    userSquareSelection = Convert.ToInt32(userSelection);                    
                }    
                catch    
                {
                    Console.WriteLine("That was not a number.");
                }
                // Check the state of the gameboard array to see if square is occupied, if not place mark in the square
                switch (userSquareSelection)
                {
                    case 0:
                        if (currentArray[0,0] == " ")
                        {
                            currentArray[0,0] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }
                    case 1:
                        if (currentArray[0,1] == " ")
                        {
                            currentArray[0,1] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }                    
                        case 2:
                        if (currentArray[0,2] == " ")
                        {
                            currentArray[0,2] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }                    
                        case 3:
                        if (currentArray[1,0] == " ")
                        {
                            currentArray[1,0] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }                    
                        case 4:
                        if (currentArray[1,1] == " ")
                        {
                            currentArray[1,1] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }                    
                        case 5:
                        if (currentArray[1,2] == " ")
                        {
                            currentArray[1,2] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }                    
                        case 6:
                        if (currentArray[2,0] == " ")
                        {
                            currentArray[2,0] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }                    
                        case 7:
                        if (currentArray[2,1] == " ")
                        {
                            currentArray[2,1] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }             
                        case 8:
                        if (currentArray[2,2] == " ")
                        {
                            currentArray[2,2] = currentPlayer;
                            return currentArray;
                        }
                        else
                        {
                            break;
                        }                        
                } 
                Console.WriteLine("That is an invalid square selection please try again!\nPlease try again by entering a valid square number:...");
                userSelection = Console.ReadLine();           
            }
        }
        static string PlayAgain()
        {
            Console.Write("Would you like to play again? (Y/N) ..."); 
            string playAgain = (Console.ReadLine()).ToUpper();
            if (playAgain == "Y" || playAgain == "YES")
            {
                return "RESET";
            }
                else if (playAgain == "N")
            {
                return "DONE";
            }
            else
            {
                Console.WriteLine("That was an invalid selection. Exiting now.");
                Thread.Sleep(500);
                return "DONE";
            }
        }
        static string Art(string status)
        {
            if (status == "draw")
            {

            
            //@ Source http://programmingisfun.com/command-line-ascii-design/
            // Purpose - creating a variable to hold ASCII ART - you need the @ for the " 
            // @ Souce https://www.asciiart.eu/ -- ASCII Art
            // @ Source https://www.coolgenerator.com/ascii-text-generator
                string meow1 = @"███╗   ███╗███████╗ ██████╗ ██╗    ██╗
████╗ ████║██╔════╝██╔═══██╗██║    ██║
██╔████╔██║█████╗  ██║   ██║██║ █╗ ██║
██║╚██╔╝██║██╔══╝  ██║   ██║██║███╗██║
██║ ╚═╝ ██║███████╗╚██████╔╝╚███╔███╔╝
╚═╝     ╚═╝╚══════╝ ╚═════╝  ╚══╝╚══╝ ";

                string cat = @"   |\---/|
   | ,_, |
    \_`_/-..----.
 ___/ `   ' ,""+ \  sk
(__...'   __\    |`.___.';
  (_,...'(_,.`__)/'...";
                return meow1;
            }
            else if (status == "X")
            {
                string playerX = @"██████╗ ██╗      █████╗ ██╗   ██╗███████╗██████╗         ██╗  ██╗
██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝██╔════╝██╔══██╗        ╚██╗██╔╝
██████╔╝██║     ███████║ ╚████╔╝ █████╗  ██████╔╝         ╚███╔╝ 
██╔═══╝ ██║     ██╔══██║  ╚██╔╝  ██╔══╝  ██╔══██╗         ██╔██╗ 
██║     ███████╗██║  ██║   ██║   ███████╗██║  ██║        ██╔╝ ██╗
╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝        ╚═╝  ╚═╝";
                return playerX;
            }
            else if (status == "O")
            {
                string playerO = @"██████╗ ██╗      █████╗ ██╗   ██╗███████╗██████╗          ██████╗ 
██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝██╔════╝██╔══██╗        ██╔═══██╗
██████╔╝██║     ███████║ ╚████╔╝ █████╗  ██████╔╝        ██║   ██║
██╔═══╝ ██║     ██╔══██║  ╚██╔╝  ██╔══╝  ██╔══██╗        ██║   ██║
██║     ███████╗██║  ██║   ██║   ███████╗██║  ██║        ╚██████╔╝
╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝         ╚═════╝ ";
                return playerO;
            }
        return "ERROR";
        }

    }
}


