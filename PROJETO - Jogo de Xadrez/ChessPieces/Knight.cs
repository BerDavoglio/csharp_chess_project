using board;

namespace ChessPieces
{
    class Knight : Piece
    {
        public Knight(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "H";
        }
    }
}
