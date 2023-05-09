using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class FileInfo : IFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
    }
}
