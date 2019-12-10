using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Player2 : Entity
    {
      private Sprite sprite;
       public  AABB hitbox;
        Turret turrent;
        public Player2(float x, float y) : base(x,y)
        {
            X = x;
            Y = y;

            sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/tankBlue.png");
            
            AddChild(sprite);
            hitbox = new AABB(sprite.Width, sprite.Height);
            AddChild(hitbox);
            turrent = new Turret(0, 0);
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
           
            //disable this on realease
            Raylib.Raylib.DrawText("Player2   X: " + X + " Y: " + Y, 1000, 5, 18, Raylib.Color.WHITE);
            Raylib.Raylib.DrawText("player2 Top: " + hitbox.Top + "Bottom: " +  hitbox.Bottom + "Left: " + hitbox.Left + "Right: " + hitbox.Right, 700, 30,18, Raylib.Color.WHITE);
        }

        public void Moveup(float deltatime)
        {
            if(Input.IsKeyDown(73)) //W
            {
                Vector3 facing = new Vector3(Getm12, Getm11, 0);

                XAcceleration = facing.x * -100;
                YAcceleration = facing.y * -100;
            }
           else if(Input.IsKeyReleased(73)) //W
            {

                XAcceleration = 0;
                XVelocity = 0;

                YAcceleration = 0;
                YVelocity = 0;
            }
            
        }

        public void TestCollision(float deltatime)
        {
            hitbox.DetectCollision(Program.player1.hitbox);
        }

        public void Movedown(float deltatime)
        {
            if (Input.IsKeyDown(75))
            {
                Vector3 facing = new Vector3(Getm12, Getm11, 0) * 100;

                XAcceleration = facing.x;
                YAcceleration = facing.y;
            }
            else if (Input.IsKeyReleased(75))
            {
                XAcceleration = 0;
                XVelocity = 0;
                YAcceleration = 0;
                YVelocity = 0;
            }
            //if (YVelocity < -.01f)
            //{
            //    YVelocity = -.01f;
            //}
        }

        public void Rotateleft(float deltatime)
        {
            if(Input.IsKeyDown(74) )
            {
                Rotate(-1f * deltatime);
            }
            else if (Input.IsKeyReleased(74))
            {
            }
        }

        public void RotateRight(float deltatime)
        {
            if (Input.IsKeyDown(76))
            {
                Rotate(1f * deltatime);
            }
            else if (Input.IsKeyReleased(76))
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
