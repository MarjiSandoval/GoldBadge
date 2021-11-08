using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactor.UI
{
    public interface IConsole
    {
        ConsoleKeyInfo ReadKey();
        string ReadLine();
        void Clear();
        void Write(string s);
        void WriteLine(object o);
        void WriteLine(string s);

    }
}
