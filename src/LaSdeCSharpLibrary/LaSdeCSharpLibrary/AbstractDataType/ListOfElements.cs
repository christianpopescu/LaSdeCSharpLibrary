using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.AbstractDataType
{
    /// <summary>
    /// Abstradt Data Type to store a list of string elements
    /// </summary>
    public class ListOfElements
    {
        /// <summary>
        /// Holds the list of elements
        /// </summary>
        public List<string> Elements { get; set; }

        /// <summary>
        /// Constructor to initialize the Elements list
        /// </summary>
        public ListOfElements()
        {
            Elements = new List<string>();
        }


        /// <summary>
        /// Reads the lines from a text and stores them in the Elements list
        /// </summary>
        /// <param name="reader"></param>
        public void LoadLines(TextReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Elements.Add(line);
            }
        }

        /// <summary>
        /// Reads the lines from a text and stores them in the Elements list
        /// </summary>
        /// <param name="text"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void LoadLines(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            using (StringReader reader = new StringReader(text))
            {
                LoadLines(reader);
            }
        }


    }
}
