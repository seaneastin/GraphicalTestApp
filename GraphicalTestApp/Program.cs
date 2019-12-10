using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        public static Player1 player1;
        public static Player2 player2;
        static void Main(string[] args)
        {

            

            Game game = new Game(1280, 760, "Tank Game by Sean");

            Actor root = new Actor();
            game.Root = root;
            player1 = new Player1(100, 100);
            player2 = new Player2(-100, -100);
            root.AddChild(player1);
            root.AddChild(player2);
            //## Set up game here ##//

            game.Run();
        }
    }
}
