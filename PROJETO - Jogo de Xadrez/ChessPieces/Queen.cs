using board;

namespace ChessPieces
{
    class Queen : Piece
    {
        public Queen(Color color, Board board) : base(color, board)
        {
        }

        public override bool[,] Possible()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position pos = new Position(0, 0);



            return mat;
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
