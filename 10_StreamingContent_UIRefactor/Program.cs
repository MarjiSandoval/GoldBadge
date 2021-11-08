using _10_StreamingContent_UIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            // IConsole console = new RealConsole();
            IConsole console = new FunConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
