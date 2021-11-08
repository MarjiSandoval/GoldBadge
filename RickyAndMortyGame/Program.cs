using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickyAndMortyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can do things like load saved game data here later...
            Program_UI game = new Program_UI();
            game.Run();
        }
    }
}
