using board;

namespace ChessPieces
{
    class Pawn : Piece
    {
        int Moviments = 0;
        public Pawn(Color color, Board board) : base(color, board)
        {
        }

        private bool CanMove(Position pos)
        {
            Piece p = Board.Piece(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] Possible()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];
            Position pos = new Position(0, 0);

            


            return mat;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
