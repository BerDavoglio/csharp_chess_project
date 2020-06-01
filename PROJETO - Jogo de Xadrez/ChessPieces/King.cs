using board;

namespace ChessPieces
{
    class King : Piece
    {
        public King(Color color, Board board) : base(color, board)
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

            // North
            pos.ValueDefine(Position.Line - 1, Position.Column);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            // South
            pos.ValueDefine(Position.Line + 1, Position.Column);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            // East
            pos.ValueDefine(Position.Line, Position.Column + 1);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            // West
            pos.ValueDefine(Position.Line, Position.Column - 1);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            // North-East
            pos.ValueDefine(Position.Line - 1, Position.Column + 1);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            // South-East
            pos.ValueDefine(Position.Line + 1, Position.Column + 1);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            // North-West
            pos.ValueDefine(Position.Line - 1, Position.Column - 1);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            // South-West
            pos.ValueDefine(Position.Line + 1, Position.Column - 1);
            if (Board.ValidationPosition(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            return mat;
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
