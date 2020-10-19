﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class HRModule
    {
        public  IFileWriter FileWriter { get; }

        public HRModule()
        {
            FileWriter = FileWriterFactory.GetFileWriterInstance();
        }
    }
}
