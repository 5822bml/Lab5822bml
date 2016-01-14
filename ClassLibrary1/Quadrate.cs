using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Core
{
    public class Quadrate : IFigure
    {
        private int _a;
        private int _b;
        public Quadrate(int a, int b)
        {
            if ((a > 0) && (b > 0))
            {
                _a = a;
                _b = b;
            }
        }
        public double ReturnSquare()
        {
            return _a * _b;
        }
    }
}
