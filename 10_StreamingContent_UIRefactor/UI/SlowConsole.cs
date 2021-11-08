using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactor.UI
{
    public class SlowConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            var input = Console.ReadKey();
            foreach (char letter in "..........")
            {
                Thread.Sleep(30);
                Console.Write(letter);
            }
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            var input = Console.ReadKey();
            for (int i = 0; i < 8; i++)
            {
                Console.Write(".");
                Console.Beep(200, 20);
                Thread.Sleep(50);
            }
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            foreach(char letter in s)
            {
                Thread.Sleep(75);
                Console.Beep(300, 20);
                Console.Write(letter);
            }
        }

        public void WriteLine(string s)
        {
            Write(s);
            Console.Write("\n");
        }

        public void WriteLine(object o)
        {
           
            Console.WriteLine(o);
        }
    }
}
