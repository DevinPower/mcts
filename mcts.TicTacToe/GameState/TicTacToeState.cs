using mcts.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcts.TicTacToe.GameState
{
    internal class TicTacToeState : iGameState
    {
        int[,] Board;
        int _boardSize;

        public TicTacToeState(int BoardSize)
        {
            Board = new int[BoardSize, BoardSize];
            _boardSize = BoardSize;
        }

        public iGameState Copy()
        {
            return new TicTacToeState(_boardSize);
        }

        public List<Action> GetAvailableMoves(int PlayerID)
        {
            List<Action> Actions = new List<Action>();
            for (int iX = 0; iX < _boardSize; iX++)
            {
                for (int iY = 0; iY < _boardSize; iY++)
                {
                    if (Board[iX, iY] == 0)
                    {
                        Actions.Add(() => {
                            PlacePiece(iX, iY, PlayerID);
                        });
                    }
                }
            }

            return Actions;
        }

        public void PlacePiece(int X, int Y, int Player)
        {
            Board[X, Y] = Player;
        }

        public void Render()
        {
            for (int iX = 0; iX < Board.GetLength(0); iX++)
            {
                for (int iY = 0; iY < Board.GetLength(1); iY++)
                {
                    switch(Board[iX, iY])
                    {
                        case 0:
                            Console.Write('-');
                            break;
                        case 1:
                            Console.Write('X');
                            break;
                        case 2:
                            Console.Write('O');
                            break;
                    }
                }
                Console.Write('\n');
            }
        }
    }
}
