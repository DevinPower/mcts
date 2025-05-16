namespace mcts.Library
{
    public class Node<T> where T : iGameState
    {
        T GameState;
        Node<T> ParentNode { get; }
        List<Node<T>> Children { get; }
        Action PlayerMove { get; }
        bool Explored = false;

        public Node(T GameState, Node<T> ParentNode, Action PlayerMove)
        {
            this.GameState = GameState;
            this.ParentNode = ParentNode;
            this.PlayerMove = PlayerMove;
        }

        public void Expand()
        {
            foreach (var availableMove in GameState.GetAvailableMoves(1))
            {
                Children.Add(new Node<T>((T)GameState.Copy(), this, availableMove));
            }
        }

        public void BackPropagate()
        {
            //do stuff

            ParentNode?.BackPropagate();
        }

        public Node<iGameState> PickBest()
        {
            throw new NotImplementedException();
        }

        public iGameState GetState()
        {
            return GameState;
        }

        public List<Node<T>> GetChildren()
        {
            return Children;
        }

        public void Simulate()
        {
            PlayerMove.Invoke();
        }
    }
}
