using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        public Tank(float x, float y) : base(x,y)
        {
            X = x;
            Y = y;

            Sprite sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/tankBlue.png");
            AddChild(sprite);
            AABB hitbox = new AABB(sprite.Width, sprite.Height);
            
            AddChild(hitbox);



            OnUpdate += moveup;
            OnUpdate += movedown;
        }

        public void moveup(float deltatime)
        {
            if(Input.IsKeyPressed(87)) //W
            {
                YAcceleration++;
                
                //Rotate(5f);
            }
           else if(Input.IsKeyReleased(87)) //W
            {
                YAcceleration = 0;
                YVelocity = 0;
            }
            if (YVelocity > .01f)
            {
                YVelocity = .01f;
                    }
        }

        public void movedown(float deltatime)
        {
            if (Input.IsKeyPressed(83))
            {
                YAcceleration--;
            }
            else if (Input.IsKeyReleased(83))
            {
                YAcceleration = 0;
                YVelocity = 0;
            }
            if (YVelocity < -.01f)
            {
                YVelocity = -.01f;
            }
        }

        public void rotateleft(float deltatime)
        {

        }

        public void rotateright(float deltatime)
        {


        }
        
    }
}
