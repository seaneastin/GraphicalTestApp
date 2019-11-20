using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;
            Tank tank = new Tank(100, 100);
            root.AddChild(tank);
            //## Set up game here ##//

            game.Run();
        }
    }
}
