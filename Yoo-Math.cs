using System;

/// <summary>
/// The future of math.
/// </summary>
namespace yoo_math
{
    /// <summary>
    /// The main class for Yoo-Math.
    /// </summary>
    public static class YooMath
    {
        /// <summary>
        /// The mathematical constant e. This is Euler's number, the base of natural logarithms.
        /// </summary>
        public static readonly double E = 2.7182818284590451;

        /// <summary>
        /// Also known as π. This is the ratio of the circumference of a circle to its diameter.
        /// </summary>
        public static readonly double PI = 3.1415926535897931;

        /// <summary>
        /// Returns true if x is negative.
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        public static bool IsNegative(decimal x) { if (x < 0) return true; else return false; }
        /// <summary>
        /// Returns true if x is negative.
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        public static bool IsNegative(double x) { if (x < 0) return true; else return false; }
        /// <summary>
        /// Returns true if x is negative.
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        public static bool IsNegative(short x) { if (x < 0) return true; else return false; }
        /// <summary>
        /// Returns true if x is negative.
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        public static bool IsNegative(int x) { if (x < 0) return true; else return false; }
        /// <summary>
        /// Returns true if x is negative.
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        public static bool IsNegative(long x) { if (x < 0) return true; else return false; }
        /// <summary>
        /// Returns true if x is negative.
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        public static bool IsNegative(sbyte x) { if (x < 0) return true; else return false; }
        /// <summary>
        /// Returns true if x is negative.
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        public static bool IsNegative(float x) { if (x < 0) return true; else return false; }

        /// <summary>
        /// Returns the y power of x;
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        /// <param name="y">The power for x.</param>
        /// <returns></returns>
        public static double Pow(double x, double y) { return Math.Pow(x, y); }

        /// <summary>
        /// Returns the y root of x;
        /// </summary>
        /// <param name="x">A numeric expression.</param>
        /// <param name="y">The root for x.</param>
        /// <returns></returns>
        public static double Root(double x, double y) { return Pow(x, 1 / y); }
    }
}