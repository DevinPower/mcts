namespace mcts.Library
{
    public interface iGameState
    {
        /// <summary>
        /// </summary>
        /// <returns>A list of all possible actions for the player/AI from this state</returns>
        List<Action> GetAvailableMoves(int PlayerID);

        /// <summary>
        /// </summary>
        /// <returns>Deep copy of the game state</returns>
        iGameState Copy();
    }
}
