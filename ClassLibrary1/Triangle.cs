using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Triangle : IFigure
    {
        private int _bottom;
        private int _heigth;
        public Triangle(int bottom, int heigth)
        {
            _bottom = bottom;
            _heigth = heigth;
        }
        public double ReturnSquare()
        {
            return 1 / 2.0 * _bottom * _heigth;
        }
    }
}
