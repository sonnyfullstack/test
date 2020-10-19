using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class SalaryModule
    {
        public IFileWriter FileWriter { get; }

        public SalaryModule()
        {
            FileWriter = FileWriterFactory.GetFileWriterInstance();
        }
    }
}
