﻿namespace board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int Moviments { get; protected set; }
        public Board Board { get; set; }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Board = board;
            Moviments = 0;
        }

        public void MoreMoviments()
        {
            Moviments++;
        }
    }
}
