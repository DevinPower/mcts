namespace mcts.Library
{
    public class MCTSSolver
    {
        Node<iGameState> Root;

        public MCTSSolver(Node<iGameState> Root) 
        {
            this.Root = Root;
        }

        public void Think()
        {
            var CurrentBest = Root.PickBest();

            CurrentBest.Expand();
            foreach (var child in CurrentBest.GetChildren())
            {
                child.Simulate();
            }
        }
    }
}
