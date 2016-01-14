using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Round : IFigure
    {
        private int _radius;
        public Round(int radius)
        {
            _radius = radius;
        }
        public double ReturnSquare()
        {
            return 3.1415 * Math.Pow(_radius, 2);
        }
    }
}
