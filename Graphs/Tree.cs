namespace Graphs
{
    public class Tree
    {
        public Node[] verticies;

        public Tree(int n)
        {
            this.N = n;
            this.verticies = new Node[this.N];
            for (var index = 0; index < this.verticies.Length; index++)
            {
                this.verticies[index] = new Node(index);
            }
        }

        public int N { get; set; }
    }
}