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
                ChessGame game = new ChessGame();

                while (!game.Terminate)
                {
                    Console.Clear();
                    Screen.PrintScreen(game.board);

                    Console.Write("\nOrigin: ");
                    Position Origin = Screen.ReadChessPosition().ToPosition();
                    Console.Write("Destiny: ");
                    Position Destiny = Screen.ReadChessPosition().ToPosition();

                    game.Moviment(Origin, Destiny);
                }             
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
