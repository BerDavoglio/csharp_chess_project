using System;
using board;
namespace PROJETO___Jogo_de_Xadrez
{
    class Screen
    {
        public static void PrintScream(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.Piece(i, j) != null)
                    {
                        Console.Write(board.Piece(i, j) + " ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
