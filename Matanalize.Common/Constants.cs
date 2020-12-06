using System;

namespace Matanalize.Common
    {
    public static class Constants
        {
        public static Func<double, double> Function = x => Math.Pow(Math.E, x) * Math.Sin(x);
        }
    }
