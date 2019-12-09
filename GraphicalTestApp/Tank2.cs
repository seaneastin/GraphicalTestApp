using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank2 : Entity
    {
        Sprite sprite;
       public  AABB hitbox;
        turrent turrent;
        public Tank2(float x, float y) : base(x,y)
        {
            X = x;
            Y = y;

            sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/tankBlue.png");
            
            AddChild(sprite);
            hitbox = new AABB(sprite.Width, sprite.Height);
            AddChild(hitbox);
            turrent = new turrent(0, 0);
            AddChild(turrent);

            //OnUpdate += moveup;
            //OnUpdate += movedown;
            //OnUpdate += rotateleft;
            //OnUpdate += rotateright;
            OnUpdate += ScreenWrap;
            OnUpdate += Drawcords;
            OnUpdate += TestCollision;
        }

        public void Drawcords(float deltatime)
        {
            Raylib.Raylib.DrawText(" X: " + X + " Y: " + Y,5,5, 5, Raylib.Color.WHITE);
        }

        public void moveup(float deltatime)
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

        public void movedown(float deltatime)
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

        public void rotateleft(float deltatime)
        {
            if(Input.IsKeyDown(65) )
            {
                Rotate(-1f * deltatime);
            }
            else if (Input.IsKeyReleased(65))
            {
            }
        }

        public void rotateright(float deltatime)
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
            if (X > Game.gamewidth || Y > Game.gameheight || X < 0 || Y < 0) //if the tank leaves the screen
            {
                Console.WriteLine("tank is offscreen");
                if(X > Game.gamewidth)
                {
                   X = 0 + 5;
                }

                if(X < 0)
                {
                    X = Game.gamewidth - 5;
                }


                if(Y > Game.gameheight)
                {
                    Y = 0 + 5;
                }

                if(Y < 0)
                {
                    Y = Game.gameheight - 5;
                }


            }
        }
        
    }
}
