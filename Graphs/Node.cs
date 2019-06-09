namespace Graphs
{
    using System.Collections.Generic;

    public class Node
    {
        public Node(int i)
        {
            this.Value = i;
            this.Color = NodeVisited.White;
            this.Edges = new LinkedList<Node>();
        }

        public enum NodeVisited
        {
            White,

            Gray
        }

        public NodeVisited Color { get; set; }

        public LinkedList<Node> Edges { get; set; }

        public Node ParentNode { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            return this.ToString(this);
        }

        private string ToString(Node n)
        {
            if (n.ParentNode != null)
            {
                return $"{this.ToString(n.ParentNode)} -> {n.Value}";
            }
            else
            {
                return n.Value.ToString();
            }
        }
    }
}