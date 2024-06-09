using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingCar_Client
{
    public static class MathUtils
    {
        public const float RadToDeg = 180f / (float)Math.PI;
        public const float DegToRad = (float)Math.PI / 180f;

        public static float Lerp(float t, float a, float b) => (1 - t) * a + b * t;

        public static float Approach(float inc, float current, float target)
        {
            if (target <= current)
                return Math.Max(target, current - inc);
            else if (target >= current)
                return Math.Min(target, current + inc);

            return target;
        }

    
    }
}
