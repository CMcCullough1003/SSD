using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Year_13_Coursework.Tools
{
    //Use this class for creating files, opening files and adding to files
    public class Files
    {
        public List<string> getFileContents(string fileName)
        {
            return File.ReadLines(fileName).ToList();
        }

        public string removeExtensions(string fileName)
        {
            string output = fileName.Replace(".jpg", "").Replace(".png", "");
            return output;
        }
    }
}
