using PROJETO___Jogo_de_Xadrez.board;

namespace board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines, Columns];
        }

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return Pieces[pos.Line, pos.Column];
        }

        public void InsertPiece(Piece p, Position pos)
        {
            if (TestPiece(pos))
            {
                throw new BoardException("There is other piece ALREADY!");
            }
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if (Piece(pos) == null)
            {
                return null;
            }
            Piece aux = Piece(pos);
            aux.Position = null;
            Pieces[pos.Line, pos.Column] = null;
            return aux;
        }

        public bool ValidationPosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public bool TestPiece(Position pos)
        {
            Validation(pos);
            return Piece(pos) != null;
        }

        public void Validation(Position pos)
        {
            if (!ValidationPosition(pos) == true)
            {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
