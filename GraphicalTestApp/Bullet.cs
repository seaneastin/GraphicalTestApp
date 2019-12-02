using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet : Entity
    {
        Sprite sprite;
        public Bullet(float x, float y) : base(x,y)
            {
            X = x;
            Y = y;
            sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Bullets/bulletBlue.png");
            AddChild(sprite);

        }
        public void destroy()
        {

        }




    }
}
