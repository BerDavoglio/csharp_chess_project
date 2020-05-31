using System;
using board;
using ChessPieces;
using PROJETO___Jogo_de_Xadrez.board;

namespace PROJETO___Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.InsertPiece(new Rook(Color.Black, board), new Position(0, 0));
                board.InsertPiece(new Rook(Color.Black, board), new Position(1, 3));
                board.InsertPiece(new Queen(Color.Black, board), new Position(4, 2));
                board.InsertPiece(new King(Color.Black, board), new Position(7, 7));

                board.InsertPiece(new Rook(Color.White, board), new Position(1, 5));
                board.InsertPiece(new Rook(Color.White, board), new Position(6, 2));
                board.InsertPiece(new Queen(Color.White, board), new Position(3, 2));
                board.InsertPiece(new King(Color.White, board), new Position(0, 4));

                Screen.PrintScreen(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
