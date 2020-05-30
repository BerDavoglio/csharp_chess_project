using System;
using board;

namespace PROJETO___Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.PrintScream(board);
        }
    }
}
