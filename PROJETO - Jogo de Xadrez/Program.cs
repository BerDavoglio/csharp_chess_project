﻿using System;
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
                board.InsertPiece(new King(Color.Black, board), new Position(2, 4));

                Screen.PrintScream(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
