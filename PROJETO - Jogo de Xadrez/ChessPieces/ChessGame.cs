﻿using System.Collections.Generic;
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
        private HashSet<Piece> Pieces;
        private HashSet<Piece> Captured;

        public ChessGame()
        {
            board = new Board(8, 8);
            turn = 1;
            GamerNow = Color.White;
            Pieces = new HashSet<Piece>();
            Captured = new HashSet<Piece>();
            PutPieces();
            Terminate = false;
        }

        public void Moviment(Position A, Position B)
        {
            Piece P = board.RemovePiece(A);
            P.MoreMoviments();
            Piece CapturedPiece = board.RemovePiece(B);
            board.InsertPiece(P, B);
            if (CapturedPiece != null)
            {
                Captured.Add(CapturedPiece);
            }
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

        public HashSet<Piece> CapturedPieces(Color c)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in Captured)
            {
                if (x.Color == c)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Piece> PiecesInGame(Color c)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in Captured)
            {
                if (x.Color == c)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(CapturedPieces(c));
            return aux;
        }

        public void PutNewPiece(Piece piece, char column, int line)
        {
            board.InsertPiece(piece, new ChessPosition(column, line).ToPosition());
            Pieces.Add(piece);
        }

        private void PutPieces()
        {
            PutNewPiece(new Rook(Color.White, board), 'a', 1);
            PutNewPiece(new Rook(Color.White, board), 'h', 1);
            //PutNewPiece(new Knight(Color.White, board)'b', 1);
            //PutNewPiece(new Knight(Color.White, board), 'g', 1);
            //PutNewPiece(new Bishop(Color.White, board), 'c', 1);
            //PutNewPiece(new Bishop(Color.White, board), 'f', 1);
            PutNewPiece(new King(Color.White, board), 'd', 1);
            //PutNewPiece(new Queen(Color.White, board), 'e', 1);
            //for (char i = 'a'; i <= 'h'; i++)
            //{
            //    PutNewPiece(new Pawn(Color.White, board), 'i', 2);
            //}

            PutNewPiece(new Rook(Color.Black, board), 'a', 8);
            PutNewPiece(new Rook(Color.Black, board), 'h', 8);
            //PutNewPiece(new Knight(Color.Black, board), 'b', 8);
            //PutNewPiece(new Knight(Color.Black, board), 'g', 8);
            //PutNewPiece(new Bishop(Color.Black, board), 'c', 8);
            //PutNewPiece(new Bishop(Color.Black, board), 'f', 8);
            board.InsertPiece(new King(Color.Black, board), new ChessPosition('d', 8).ToPosition());
            //PutNewPiece(new Queen(Color.Black, board), 'e', 8);
            //for (char i = 'a'; i <= 'h'; i++)
            //{
            //    PutNewPiece(new Pawn(Color.Black, board), 'i', 7);
            //}
        }
    }
}
