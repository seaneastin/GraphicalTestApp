using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        public static Tank player1;
        public static Tank2 player2;
        static void Main(string[] args)
        {

            

            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;
            player1 = new Tank(100, 100);
            player2 = new Tank2(-100, -100);
            root.AddChild(player2);
            root.AddChild(player1);
            //## Set up game here ##//

            game.Run();
        }
    }
}
