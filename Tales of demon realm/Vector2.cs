using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class Vector2 : IEquatable<Vector2>
    {
        public int value1;
        public int value2;

        public Vector2(int value1, int value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public bool Equals(Vector2 other)
        {
            return value1 == other.value1 && value2 == other.value2;
        }

        public static Vector2 operator +(Vector2 current, Vector2 other) {
            return new Vector2(current.value1 + other.value1, current.value2 + other.value2);
        }
    }
}
