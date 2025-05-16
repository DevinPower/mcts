using mcts.Library;
using mcts.TicTacToe.GameState;

internal class Program
{
    private static void Main(string[] args)
    {
        TicTacToeState gamestate = new TicTacToeState(3);

        while (true)
        {
            RenderGame(gamestate);
            PlayerMove(gamestate);
            AIMove(gamestate);
        }
    }

    static bool PlayerMove(TicTacToeState GameState)
    {
        string input = Console.ReadLine();

        string[] splits = input.Split(' ');
        if (!int.TryParse(splits[0], out int X))
            return false;

        if (!int.TryParse(splits[1], out int Y))
            return false;

        GameState.PlacePiece(X, Y, 1);

        return true;
    }

    static void AIMove(TicTacToeState GameState)
    {
        GameState.PlacePiece(0, 0, 2);
    }

    static void RenderGame(TicTacToeState GameState)
    {
        Console.Clear();
        GameState.Render();
    }
}