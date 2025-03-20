using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpSandbox
{
    // List of String elements

    public class ListOfElements
    {
        public List<string> Elements { get; set; }

        // Constructor to initialize the Elements list
        public ListOfElements()
        {
            Elements = new List<string>();
        }

        public void LoadFromFileLines(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Elements.Add(line);
                }
            }

        }
    }
}
