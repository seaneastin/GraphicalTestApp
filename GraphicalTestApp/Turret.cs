using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Turret : Entity
    {
        int maxammo = 5;
        Timer timer = new Timer();
        int ammo = 5;
        Sprite tankturrent;
        public Turret(float x, float y) : base(x, y)
        {

            tankturrent = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/barrelBlue.png");
            
            tankturrent.X = -5;
            tankturrent.Y = -40;
            X = x;
            Y = y;



            AddChild(tankturrent);
            OnUpdate += rotateleft;
            OnUpdate += rotateright;
            OnUpdate += fire;
            OnUpdate += restoreammo;

        }

        public void rotateleft(float deltatime)
        {
            if (Input.IsKeyDown(81))
            {

                Rotate(-1f * deltatime);
            }
        }


        public void rotateright(float deltatime)
        {
            if (Input.IsKeyDown(69)) //nice
            {

                Rotate(1f * deltatime);
            }
        }

        public void fire(float deltatime)
        {
            if (Input.IsKeyPressed(32))
            {
                if (ammo > 0)
                {
                    Bullet bullet = new Bullet(XAbsolute, YAbsolute);
                    Parent.Parent.AddChild(bullet);
                    Vector3 facing = new Vector3(Getm12, Getm11, 0);
                    bullet.Rotate(GetRotation());
                    bullet.XAcceleration = facing.x * -200;
                    bullet.YAcceleration = facing.y * -200;
                    ammo--;
                    Console.WriteLine("ammo is now (" + ammo + "/5)");
                }
            }
        }

        public void restoreammo(float deltatime)
        {
            if (ammo < maxammo && timer.Seconds >= 2)
            {
                ammo++;
                timer.Restart();
                Console.WriteLine("ammo restored.");
                Console.WriteLine("ammo is now (" + ammo + "/5)");
            }

        }


    }
}
