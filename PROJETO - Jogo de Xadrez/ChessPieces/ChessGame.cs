using System;
using board;
using PROJETO___Jogo_de_Xadrez.board;

namespace ChessPieces
{
    class ChessGame
    {
        public Board board { get; private set; }
        public int turn { get; private set; }
        public Color GamerNow { get; private set; }
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

        public void PlayRealize(Position A, Position B)
        {
            Moviment(A, B);
            turn++;
            Change();
        }

        private void Change()
        {
            if (GamerNow == Color.White)
            {
                GamerNow = Color.Black;
            }
            else
            {
                GamerNow = Color.White;
            }
        }

        public void ValidationOrigin(Position pos)
        {
            if (board.Piece(pos) == null)
            {
                throw new BoardException("THERE IS NO PIECE TO MOVE!");
            }
            if (GamerNow != board.Piece(pos).Color)
            {
                throw new BoardException("YOU CAN JUST MOVE YOUR OWN PIECES!");
            }
            if (!board.Piece(pos).PossibleExist())
            {
                throw new BoardException("THERE IS NO POSSIBLE MOVIMENTS!");
            }
        }

        public void ValidationDestiny(Position Origin, Position Destiny)
        {
            if (!board.Piece(Origin).CanMoveTo(Destiny))
            {
                throw new BoardException("CAN NOT MOVE TO THIS POSITION!");
            }
        }

        private void PutPieces()
        {
            board.InsertPiece(new Rook(Color.White, board), new ChessPosition('a', 1).ToPosition());
            board.InsertPiece(new Rook(Color.White, board), new ChessPosition('h', 1).ToPosition());
            //board.InsertPiece(new Knight(Color.White, board), new ChessPosition('b', 1).ToPosition());
            //board.InsertPiece(new Knight(Color.White, board), new ChessPosition('g', 1).ToPosition());
            //board.InsertPiece(new Bishop(Color.White, board), new ChessPosition('c', 1).ToPosition());
            //board.InsertPiece(new Bishop(Color.White, board), new ChessPosition('f', 1).ToPosition());
            board.InsertPiece(new King(Color.White, board), new ChessPosition('d', 1).ToPosition());
            //board.InsertPiece(new Queen(Color.White, board), new ChessPosition('e', 1).ToPosition());
            //for (char i = 'a'; i <= 'h'; i++)
            //{
            //    board.InsertPiece(new Pawn(Color.White, board), new ChessPosition(i, 2).ToPosition());
            //}

            board.InsertPiece(new Rook(Color.Black, board), new ChessPosition('a', 8).ToPosition());
            board.InsertPiece(new Rook(Color.Black, board), new ChessPosition('h', 8).ToPosition());
            //board.InsertPiece(new Knight(Color.Black, board), new ChessPosition('b', 8).ToPosition());
            //board.InsertPiece(new Knight(Color.Black, board), new ChessPosition('g', 8).ToPosition());
            //board.InsertPiece(new Bishop(Color.Black, board), new ChessPosition('c', 8).ToPosition());
            //board.InsertPiece(new Bishop(Color.Black, board), new ChessPosition('f', 8).ToPosition());
            board.InsertPiece(new King(Color.Black, board), new ChessPosition('d', 8).ToPosition());
            //board.InsertPiece(new Queen(Color.Black, board), new ChessPosition('e', 8).ToPosition());
            //for (char i = 'a'; i <= 'h'; i++)
            //{
            //    board.InsertPiece(new Pawn(Color.Black, board), new ChessPosition(i, 7).ToPosition());
            //}
        }
    }
}
