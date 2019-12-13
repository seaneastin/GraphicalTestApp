using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public override string ToString()
        {
            return "{ " + x + ", " + y + "," + z + "}";
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        public static Vector3 operator /(float number, Vector3 rhs)
        {
            return new Vector3(number / rhs.x, number / rhs.y, number / rhs.z);
        }
        public static Vector3 operator /(Vector3 lhs, float number)
        {
            return new Vector3(lhs.x / number, lhs.y / number, lhs.z / number);
        }
        public static Vector3 operator *(float number, Vector3 rhs)
        {
            return new Vector3(number * rhs.x, number * rhs.y, number * rhs.z);
        }
        public static Vector3 operator *(Vector3 lhs, float number)
        {
            return new Vector3(lhs.x * number, lhs.y * number, lhs.z * number);
        }









    }
}
