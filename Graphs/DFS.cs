namespace Graphs
{
    using System;

    public class DFS
    {
        public DFS(Tree data)
        {
            foreach (Node head in data.verticies)
            {
                head.Color = Node.NodeVisited.White;
                head.ParentNode = null;
            }

            foreach (Node node in data.verticies)
            {
                if (node.Color == Node.NodeVisited.White)
                {
                    this.Traverse(data, node);
                }
            }
        }

        private void Traverse(Tree data, Node node)
        {
            node.Color = Node.NodeVisited.Gray;
            Console.WriteLine(node);
            foreach (Node v in node.Edges)
            {
                if (v.Color == Node.NodeVisited.White)
                {
                    v.ParentNode = node;
                    this.Traverse(data, v);
                }
            }
        }
    }
}