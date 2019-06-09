namespace Graphs
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory("../../..");
            Console.WriteLine(Directory.GetCurrentDirectory());
            var fileReader = new FileReader("graph2.txt"); //https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/
            //https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/
            Tree tree = fileReader.GetDataModel();
            Console.WriteLine("DFS: ");
            DFS x = new DFS(tree);
            Console.WriteLine("BFS: ");
            BFS b = new BFS(tree);
            Console.ReadKey();
        }
    }
}