using System;
using System.Collections.Generic;
using System.Text;

namespace board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Piece;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Piece = new Piece[Lines, Columns];
        }
    }
}
