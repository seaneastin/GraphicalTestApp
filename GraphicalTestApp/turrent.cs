using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class turrent : Entity
    {
        int ammo;
        Sprite tankturrent;
        public turrent(float x, float y) : base(x, y)
        {
            ammo = 5;
            tankturrent = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/barrelBlue.png");
            tankturrent.X = -5;
            tankturrent.Y = 0;
            X = x;
            Y = y;
            AddChild(tankturrent);

            OnUpdate += rotateleft;
            OnUpdate += rotateright;
            OnUpdate += fire;
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
                    Bullet bullet = new Bullet(0, 0);
                    Parent.Parent.AddChild(bullet);
                    Vector3 facing = new Vector3(Getm12, Getm11, 0);
                    bullet.XAcceleration = facing.x * .09f;
                    bullet.YAcceleration = facing.y * .09f;
                    ammo--;
                }
            }
        }

        public void restoreammo()
        {

        }


    }
}
