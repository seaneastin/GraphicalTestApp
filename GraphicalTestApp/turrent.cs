using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class turrent : Entity
    {
        public turrent(float x, float y) : base(x,y)
        {
          Sprite  tankturrent = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/tankBlue.png");
            X = x;
            Y = y;
        }
    }
}
