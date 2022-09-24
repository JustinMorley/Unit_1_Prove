using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>{"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            showBoard(numbers);
            string player = "x";
            int turn = 1;
            while (turn < 9)
            {
                playerTurn(numbers, player);
                showBoard(numbers);
                player = playerChange(player);
                turn = turn + 1;
            }
            

            

        
        }

        static void showBoard(List<string> board)
        {
            /// Prints out the board
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

         static void playerTurn(List<string> board, string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();
            int choice = int.Parse(move_string);
            int index = choice - 1;
            board[index] = currentPlayer;
        }

        static string playerChange(string currentPlayer)
        {
            string nextPlayer = "x";

            if(currentPlayer == "x")
            {
                nextPlayer = "o";
            }
            return nextPlayer;
        }
    }
}
