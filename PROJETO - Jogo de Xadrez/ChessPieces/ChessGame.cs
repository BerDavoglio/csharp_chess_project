using System;
using board;

namespace ChessPieces
{
    class ChessGame
    {
        public Board board { get; private set; }
        private int turn;
        private Color GamerNow;
        public bool Terminate { get; private set; }

        public ChessGame()
        {
            board = new Board(8, 8);
            turn = 1;
            GamerNow = Color.White;
            PutPieces();
            Terminate = false;
        }

        public void Moviment(Position A, Position B)
        {
            Piece P = board.RemovePiece(A);
            P.MoreMoviments();
            Piece CapturedPiece = board.RemovePiece(B);
            board.InsertPiece(P, B);
        }

        private void PutPieces()
        {
            board.InsertPiece(new Rook(Color.White, board), new ChessPosition('a', 1).ToPosition());
            board.InsertPiece(new Rook(Color.White, board), new ChessPosition('h', 1).ToPosition());
            board.InsertPiece(new Knight(Color.White, board), new ChessPosition('b', 1).ToPosition());
            board.InsertPiece(new Knight(Color.White, board), new ChessPosition('g', 1).ToPosition());
            board.InsertPiece(new Bishop(Color.White, board), new ChessPosition('c', 1).ToPosition());
            board.InsertPiece(new Bishop(Color.White, board), new ChessPosition('f', 1).ToPosition());
            board.InsertPiece(new King(Color.White, board), new ChessPosition('d', 1).ToPosition());
            board.InsertPiece(new Queen(Color.White, board), new ChessPosition('e', 1).ToPosition());
            for (char i = 'a'; i <= 'h'; i++)
            {
                board.InsertPiece(new Pawn(Color.White, board), new ChessPosition(i, 2).ToPosition());
            }

            board.InsertPiece(new Rook(Color.Black, board), new ChessPosition('a', 8).ToPosition());
            board.InsertPiece(new Rook(Color.Black, board), new ChessPosition('h', 8).ToPosition());
            board.InsertPiece(new Knight(Color.Black, board), new ChessPosition('b', 8).ToPosition());
            board.InsertPiece(new Knight(Color.Black, board), new ChessPosition('g', 8).ToPosition());
            board.InsertPiece(new Bishop(Color.Black, board), new ChessPosition('c', 8).ToPosition());
            board.InsertPiece(new Bishop(Color.Black, board), new ChessPosition('f', 8).ToPosition());
            board.InsertPiece(new King(Color.Black, board), new ChessPosition('d', 8).ToPosition());
            board.InsertPiece(new Queen(Color.Black, board), new ChessPosition('e', 8).ToPosition());
            for (char i = 'a'; i <= 'h'; i++)
            {
                board.InsertPiece(new Pawn(Color.Black, board), new ChessPosition(i, 7).ToPosition());
            }
        }
    }
}
