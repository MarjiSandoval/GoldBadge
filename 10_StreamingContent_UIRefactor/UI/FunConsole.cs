using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactor.UI
{
    public class FunConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
            Console.BackgroundColor = RndColor();
        }

        public ConsoleColor RndColor()
        {
            Thread.Sleep(50);
            Random randy = new Random();
            int colorIndex = randy.Next(0, 16);
            return (ConsoleColor)colorIndex;
        }

        //Black 0//DarkBlue 1//DarkGreen 2//DarkCyan 3//DarkRed 4//DarkMagenta 5//DarkYellow 6//Gray //DarkGray 8//Blue 9//Green 10//Cyan 11//Red 12//Magenta 13//Yellow 14//White 15


        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Umm......");
            Thread.Sleep(1000);
            Console.WriteLine("You sure...?");
            Thread.Sleep(1000);
            Console.WriteLine("...okay");
            return input;
        }

        public void Write(string s)
        {
            foreach (char letter in s) 
            {
                Console.ForegroundColor = RndColor();
                Console.Write(letter);
            }
        }

        public void WriteLine(string s)
        {
            //sPoNgEbOb MeMe CaSe
            Console.ForegroundColor = RndColor();
            bool capitalize = false;
            foreach (char letter in s)
            {
                if (capitalize)
                {
                    Console.Write(char.ToUpper(letter));
                    capitalize = false;
                }
                else
                {
                    Console.Write(char.ToLower(letter));
                    capitalize = true;
                }
            }
            Thread.Sleep(50);
            Console.WriteLine("\n");
        }

        public void WriteLine(object o)
        {

           Console.ForegroundColor = RndColor();
            Console.WriteLine(o);
        }
    }
}
