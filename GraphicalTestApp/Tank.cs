using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
      private Sprite sprite;
       public  AABB hitbox;
        Turrent turrent;
        public Tank(float x, float y) : base(x,y)
        {
            X = x;
            Y = y;

            sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/tankBlue.png");
            
            AddChild(sprite);
            hitbox = new AABB(sprite.Width, sprite.Height);
            AddChild(hitbox);
            turrent = new Turrent(0, 0);
            AddChild(turrent);

            OnUpdate += Moveup;
            OnUpdate += Movedown;
            OnUpdate += Rotateleft;
            OnUpdate += RotateRight;
            OnUpdate += ScreenWrap;
            OnUpdate += Drawcords;
            OnUpdate += TestCollision;
        }

        public void Drawcords(float deltatime)
        {
            Raylib.Raylib.DrawText(" X: " + X + " Y: " + Y,5,5, 5, Raylib.Color.WHITE);
        }

        public void Moveup(float deltatime)
        {
            if(Input.IsKeyDown(87)) //W
            {
                Vector3 facing = new Vector3(Getm12, Getm11, 0);

                XAcceleration = facing.x * -100;
                YAcceleration = facing.y * -100;
            }
           else if(Input.IsKeyReleased(87)) //W
            {

                XAcceleration = 0;
                XVelocity = 0;

                YAcceleration = 0;
                YVelocity = 0;
            }
            
        }

        public void TestCollision(float deltatime)
        {
           // hitbox.DetectCollision();
        }

        public void Movedown(float deltatime)
        {
            if (Input.IsKeyDown(83))
            {
                Vector3 facing = new Vector3(Getm12, Getm11, 0) * 100;

                XAcceleration = facing.x;
                YAcceleration = facing.y;
            }
            else if (Input.IsKeyReleased(83))
            {
                //XAcceleration = 0;
                //XVelocity = 0;
                //YAcceleration = 0;
                //YVelocity = 0;
            }
            ////if (YVelocity < -.01f)
            ////{
            ////    YVelocity = -.01f;
            ////}
        }

        public void Rotateleft(float deltatime)
        {
            if(Input.IsKeyDown(65) )
            {
                Rotate(-1f * deltatime);
            }
            else if (Input.IsKeyReleased(65))
            {
            }
        }

        public void RotateRight(float deltatime)
        {
            if (Input.IsKeyDown(68))
            {
                Rotate(1f * deltatime);
            }
            else if (Input.IsKeyReleased(68))
            {
            }
           

        }

        public void ScreenWrap(float deltatime)
        {
            if (X > Game.gameWidth || Y > Game.gameHeight || X < 0 || Y < 0) //if the tank leaves the screen
            {
                Console.WriteLine("tank is offscreen");
                if(X > Game.gameWidth)
                {
                   X = 0 + 5;
                }

                if(X < 0)
                {
                    X = Game.gameWidth - 5;
                }


                if(Y > Game.gameHeight)
                {
                    Y = 0 + 5;
                }

                if(Y < 0)
                {
                    Y = Game.gameHeight - 5;
                }


            }
        }
        
    }
}
