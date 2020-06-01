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
                    bool[,] possibleposition = game.board.Piece(Origin).Possible();

                    Console.Clear();
                    Screen.PrintScreen(game.board, possibleposition);

                    Console.Write("\nDestiny: ");
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
