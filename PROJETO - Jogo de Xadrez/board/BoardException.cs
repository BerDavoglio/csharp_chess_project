using System;

namespace PROJETO___Jogo_de_Xadrez.board
{
    class BoardException : Exception
    {
        public BoardException(string message) : base(message)
        {
        }
    }
}
