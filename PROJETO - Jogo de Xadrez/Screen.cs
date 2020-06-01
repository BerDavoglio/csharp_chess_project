using System;
using board;
using ChessPieces;

namespace PROJETO___Jogo_de_Xadrez
{
    class Screen
    {
        public static void PrintScreen(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.Piece(i, j) != null)
                    {
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
        }

        public static ChessPosition ReadChessPosition()
        {
            string s = Console.ReadLine();
            char ch = s[0];
            int n = int.Parse(s[1] + "");

            return new ChessPosition(ch, n);
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
