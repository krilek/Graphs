namespace Graphs
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class FileReader
    {
        public FileReader(string path)
        {
            Lines = File.ReadAllLines(path).ToList();
        }

        public List<string> Lines { get; set; }

        public Tree GetDataModel()
        {
            int n = Convert.ToInt32(this.Lines[0]);
            this.Lines = this.Lines.Skip(1).ToList();
            var graphDataModel = new Tree(n);
            for (int i = 0; i < n; i++)
            {
                var strings = this.Lines[i].Split(" ");
                for (int j = 0; j < strings.Length; j++)
                {
                    if (strings[j] == "1")
                    {
                        graphDataModel.verticies[i].Edges.AddLast(graphDataModel.verticies[j]);
                    }
                }
            }

            return graphDataModel;
        }
    }
}