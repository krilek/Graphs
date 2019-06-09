namespace Graphs
{
    using System;
    using System.Collections.Generic;

    public class BFS
    {
        public BFS(Tree tree)
        {
            foreach (Node vertice in tree.verticies)
            {
                vertice.Color = Node.NodeVisited.White;
                vertice.ParentNode = null;
            }

            foreach (Node vertice in tree.verticies)
            {
                if (vertice.Color == Node.NodeVisited.White)
                {
                    this.Traverse(vertice);
                }
            }
        }

        private void PrintQueue(Queue<Node> queue)
        {
            Console.Write("Queue contents: ");
            foreach (Node node in queue)
            {
                Console.Write($"{node.Value} ");
            }

            Console.WriteLine();
        }

        private void Traverse(Node s)
        {
            s.Color = Node.NodeVisited.Gray;
            var queue = new Queue<Node>();
            queue.Enqueue(s);
            while (queue.Count != 0)
            {
                this.PrintQueue(queue);
                Node u = queue.Dequeue();
                Console.WriteLine(u);
                foreach (Node v in u.Edges)
                {
                    if (v.Color != Node.NodeVisited.White) continue;
                    v.Color = Node.NodeVisited.Gray;
                    v.ParentNode = u;
                    queue.Enqueue(v);
                }
            }
        }
    }
}