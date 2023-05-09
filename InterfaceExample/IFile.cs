using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }
}
