using System;

namespace MyApp // Justin Morley: Unit 1 Prove (Tic Tac Toe)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>{"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            showBoard(numbers);
            string player = "x";
            int turn = 1;
            while (turn < 10 && IsWinner(numbers, "x") == false && IsWinner(numbers, "o") == false)
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
            // Executes the players turn
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();
            int choice = int.Parse(move_string);
            int index = choice - 1;
            board[index] = currentPlayer;
        }

        static string playerChange(string currentPlayer)
        {
            // changes which players turn it is
            string nextPlayer = "x";

            if(currentPlayer == "x")
            {
                nextPlayer = "o";
            }
            return nextPlayer;
        }

        static bool IsWinner(List<string> board, string player)
        {
            bool isWinner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                isWinner = true;
            }

            return isWinner; 
        }
    }
}
