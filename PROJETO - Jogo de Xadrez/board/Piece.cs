namespace board
{
    abstract class Piece
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

        public bool PossibleExist()
        {
            bool[,] mat = Possible();
            for (int i = 0; i < Board.Lines; i++)
            {
                for (int j = 0; j < Board.Columns; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CanMoveTo(Position pos)
        {
            return Possible()[pos.Line, pos.Column];
        }

        public void MoreMoviments()
        {
            Moviments++;
        }

        public abstract bool[,] Possible();
    }
}
