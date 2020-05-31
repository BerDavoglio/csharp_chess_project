using System;
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
                ChessPosition pos = new ChessPosition('a', 1);

                Console.WriteLine(pos);

                Console.WriteLine(pos.ToPosition());
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
