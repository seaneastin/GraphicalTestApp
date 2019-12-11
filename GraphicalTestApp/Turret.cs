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
        private int _playernumber;
        int rotateleftcontrol;
        int rotaterightcontrol;
        int firecontrol;
        string bulletsprite;
        public Turret(float x, float y, string sprite, int playernumber, string bulletSprite) : base(x, y)
        {

            bulletsprite = bulletSprite;



            _playernumber = playernumber;

            if (_playernumber == 2)
            {
                rotateleftcontrol = 85;
                rotaterightcontrol = 79;
                firecontrol = 257;
            }


            if (_playernumber == 1)
            {
                rotateleftcontrol = 81;
                rotaterightcontrol = 69; //nice
                firecontrol = 32;
            }


            tankturrent = new Sprite(sprite);
            
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
            if (Input.IsKeyDown(rotateleftcontrol))
            {

                Rotate(-1f * deltatime);
            }
        }


        public void rotateright(float deltatime)
        {
            if (Input.IsKeyDown(rotaterightcontrol))
            {

                Rotate(1f * deltatime);
            }
        }

        public void fire(float deltatime)
        {
            if (Input.IsKeyPressed(firecontrol))
            {
                if (ammo > 0)
                {
                    Bullet bullet = new Bullet(XAbsolute, YAbsolute, _playernumber, bulletsprite);
                    Parent.Parent.AddChild(bullet);
                    Vector3 facing = new Vector3(Getm12, Getm11, 0);
                    bullet.Rotate(GetRotation());
                    bullet.XVelocity = facing.x * -200;
                    bullet.YVelocity = facing.y * -200;
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
