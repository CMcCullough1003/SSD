﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Year_13_Coursework.Tools
{
    public class Files
    {
        public Boolean checkFileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public List<string> getFileContents(string fileName)
        {
            return File.ReadLines(fileName).ToList();
        }
    }
}
