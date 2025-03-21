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
    }
}
namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
        }
    }
}
public void DrawBoard()
{
    Console.Clear();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i, j]);
            if (j < 2) Console.Write(" | ");
        }
        Console.WriteLine();
        if (i < 2) Console.WriteLine("---------");
    }
}
