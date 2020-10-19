using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class TextFileWriter : IFileWriter
    {
        public string Extension { get { return ".txt"; } }

        public string WriteToFile(string fileName)
        {
            return $"har skrivit {fileName + Extension}-fil till disk";
        }
    }
}
