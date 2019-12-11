using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet : Entity
    {
        AABB hitbox;
        Sprite sprite;
        int _playernumber;
        public Bullet(float x, float y, int playernumber, string Sprite) : base(x,y)
            {
            _playernumber = playernumber;
            X = x;
            Y = y;
            sprite = new Sprite(Sprite);
            AddChild(sprite);
            hitbox = new AABB(sprite.Width, sprite.Height);
            AddChild(hitbox);
            OnUpdate += OnColide;
        }

        ~Bullet()
            {
            if (Parent != null)
            {
                Parent.RemoveChild(this);
            }
            RemoveChild(hitbox);
            RemoveChild(sprite);
            Console.WriteLine("BulletDeconstructed");
        }

        public void OnColide(float deletatime)
        {
            if (hitbox.DetectCollision(Program.player1.hitbox) && _playernumber != 1)
            {
                Program.player1.Destroy();
            }

            if (hitbox.DetectCollision(Program.player2.hitbox) && _playernumber != 2)
            {
                Program.player2.Destroy();
            }




            if (X > Game.gameWidth || Y > Game.gameHeight || X < 0 || Y < 0) //if the bullet leaves the screen
            {
                destroy();
                
            }

        }


        public void destroy()
        {

            Console.WriteLine("bullet destroyed");
            Parent.RemoveChild(this);
        }

        public void fire()
        {
            //may use ths to organize code
        }






    }
}
