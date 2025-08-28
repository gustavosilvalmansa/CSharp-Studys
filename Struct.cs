using System;
using System.Globalization;

namespace FirstProject
{
    public struct Point
    {

        public double X, Y;
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}