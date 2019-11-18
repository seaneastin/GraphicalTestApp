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


        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Min(a.x, b.x), Math.Min(a.y, b.y), Math.Min(a.z, b.z));
        }

        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Max(a.x, a.y), Math.Max(a.y, b.y), Math.Max(a.z, b.z));
        }

        public static Vector3 Clamp(Vector3 t, Vector3 a, Vector3 b)
        {
            return Max(a, Min(b, t));
        }

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


        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }

        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
        }

        public Vector3 GetNormalised()
        {
            return (this / Magnitude());
        }

        public float DotProduct(Vector3 other)
        {
            return ((x * other.x) + (y * other.y) + (z * other.z));
        }

        public Vector3 CrossProduct(Vector3 other)
        {
            return new Vector3(y * other.z - z * other.y, z * other.x - x * other.z, x * other.y - y * other.x);
        }


        public float AngleBetween(Vector3 other)
        {
            Vector3 a = GetNormalised();
            Vector3 b = other.GetNormalised();

            float d = a.DotProduct(b);

            return (float)Math.Acos(d);
        }


    }
}
