using System;
using System.Collections.Generic;
using board;
using ChessPieces;

namespace PROJETO___Jogo_de_Xadrez
{
    class Screen
    {
        public static void PrintGame(ChessGame game)
        {
            Screen.PrintScreen(game.board);
            PrintCapturedPieces(game);
            Console.WriteLine("\nTurn: " + game.turn);
            Console.WriteLine($"Waiting Player: {game.GamerNow}");
        }

        public static void PrintCapturedPieces(ChessGame game)
        {
            Console.WriteLine("Captured Pieces: ");
            Console.Write($"White: ");
            PrintStack(game.CapturedPieces(Color.White));
            Console.WriteLine();
            Console.Write($"Black: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintStack(game.CapturedPieces(Color.Black));
            Console.ForegroundColor = aux;
        }

        public static void PrintStack(HashSet<Piece> conj)
        {
            Console.Write("[ ");
            foreach (Piece p in conj)
            {
                Console.Write(p + " ");
            }
            Console.Write("]");
        }

        public static void PrintScreen(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    PrintPiece(board.Piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
        }

        public static void PrintScreen(Board board, bool[,] positionPossible)
        {
            ConsoleColor Original = Console.BackgroundColor;
            ConsoleColor Altered = ConsoleColor.DarkGray;

            for (int i = 0; i < board.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (positionPossible[i, j] == true)
                    {
                        Console.BackgroundColor = Altered;
                    }
                    else
                    {
                        Console.BackgroundColor = Original;
                    }
                    PrintPiece(board.Piece(i, j));
                    Console.BackgroundColor = Original;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
            Console.BackgroundColor = Original;
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
            if (piece == null)
            {
                Console.Write("- ");
            }

            else
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
                Console.Write(" ");
            }
        }
    }
}
