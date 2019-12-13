using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Player1 : Entity
    {
      private Sprite _sprite;
       public  AABB hitbox;
        Turret turret;
  
        public Player1(float x, float y) : base(x,y)
        {
            X = x;
            Y = y;

            _sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/tankBlue.png");
            
            AddChild(_sprite);
            hitbox = new AABB(_sprite.Width, _sprite.Height);
            AddChild(hitbox);
            turret = new Turret(0, 0, "GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/barrelBlue.png", 1, "GraphicalTestApp/Assets/topdowntanks/PNG/Bullets/bulletBlue_outline.png");
            AddChild(turret);

            OnUpdate += Moveup;
            OnUpdate += Movedown;
            OnUpdate += Rotateleft;
            OnUpdate += RotateRight;
            OnUpdate += ScreenWrap;
            OnDraw += Drawdebugstuff;
            OnUpdate += CollidewithTank;
        }


        ~Player1()
        {
            if (Parent != null)
            {
                Parent.RemoveChild(this);
            }

            RemoveChild(hitbox);
            RemoveChild(_sprite);

        }



        public void Drawdebugstuff()
        {
            //this is not to be in the game on realease
            //disable this on realease
            Raylib.Raylib.DrawText("Player1   X: " + X + " Y: " + Y, 5, 5, 20, Raylib.Color.WHITE);
            Raylib.Raylib.DrawText("player1 Top: " + hitbox.Top + "Bottom: " +  hitbox.Bottom + "Left: " + hitbox.Left + "Right: " + hitbox.Right, 12,30, 18, Raylib.Color.WHITE);
        }



        //this is all the functions for movement
       
        public void Moveup(float deltatime)
        {
            if (Input.IsKeyDown(87)) //W
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
                XAcceleration = 0;
                XVelocity = 0;
                YAcceleration = 0;
                YVelocity = 0;
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







        public void CollidewithTank(float deltatime)
        {
            if (hitbox.DetectCollision(Program.player2.hitbox))
            {
                // Destroy(); this does not work as it destroys the player when the game starts
            }
        }

        public void ScreenWrap(float deltatime) //prevents the player from leaving the screen
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

        public void Destroy()
        {
            if (Parent != null)
            {
                Parent.RemoveChild(this);
            }
            RemoveChild(hitbox);
            RemoveChild(turret);
            
        }
        
    }
}
