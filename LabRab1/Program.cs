using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeadForm());
            //IFigure[] figure = new IFigure[3];
            //figure[0] = new Sphere(10);
            //figure[1] = new Pyramid(1, 2);
            //figure[2] = new Parallelepiped(1, 2, 3);
            //for (int i = 0; i < 3; i++)
            //{
            //    System.Console.WriteLine(figure[i].ReturnVolume());
            //}
            //System.Console.ReadLine();
        }
    }
}
