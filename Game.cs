using System;

namespace TicTacToe
{
    class Game
    {
        private char[,] board = new char[3, 3];
        private char currentPlayer = 'X';

        public Game()
        {
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = ' ';
        }
        public void Start()
        {
            while (true)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer}, it's your turn!");

                int row, col;
                while (true)
                {
                    Console.Write("Enter row (0-2): ");
                    bool rowParsed = int.TryParse(Console.ReadLine(), out row);
                    Console.Write("Enter column (0-2): ");
                    bool colParsed = int.TryParse(Console.ReadLine(), out col);

                    if (rowParsed && colParsed && IsValidMove(row, col))
                        break;

                    Console.WriteLine("Invalid input! Try again.");
                }

                board[row, col] = currentPlayer;

                if (CheckWinner())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    Console.ResetColor();
                    break;
                }

                if (IsBoardFull())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a draw!");
                    Console.ResetColor();
                    break;
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }
        private void DrawBoard()
        {
            Console.WriteLine("  0   1   2 ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.ForegroundColor = (board[i, j] == 'X') ? ConsoleColor.Cyan : ConsoleColor.Red;
                    Console.Write(board[i, j] == ' ' ? " " : board[i, j].ToString());
                    Console.ResetColor();
                    if (j < 2) Console.Write(" | ");
                    }
                    Console.WriteLine();
                    if (i < 2) Console.WriteLine(" ---+---+---");
                    }
                    }

        private bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ';
        }
private bool CheckWinner()
{
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) return true;
        if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer) return true;
    }
    if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) return true;
    if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer) return true;

    return false;
}
private bool IsBoardFull()
        {
            foreach (char cell in board)
                if (cell == ' ')
                    return false;
            return true;
        }
    }
}
