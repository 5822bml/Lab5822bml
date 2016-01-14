using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }
        
        private void buttonSphere_Click(object sender, EventArgs e)
        {
            RoundForm windowRound = new RoundForm();
            windowRound.Show();
        }

        private void buttonPiram_Click(object sender, EventArgs e)
        {
            TriangleForm windowTriangle = new TriangleForm();
            windowTriangle.Show();
        }

        private void buttonParall_Click(object sender, EventArgs e)
        {
            QuadrateForm windowQuadrate = new QuadrateForm();
            windowQuadrate.Show();
        }
    }
}
