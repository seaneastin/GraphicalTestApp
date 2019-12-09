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
        public Bullet(float x, float y) : base(x,y)
            {
            X = x;
            Y = y;
            sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Bullets/bulletBlue_outline.png");
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
            hitbox.DetectCollision(Program.player1.hitbox);
            if (X > Game.gamewidth || Y > Game.gameheight || X < 0 || Y < 0) //if the bullet leaves the screen
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
