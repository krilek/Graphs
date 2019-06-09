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
            this.Lines = new List<string>();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                do
                {
                    this.Lines.Add(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
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