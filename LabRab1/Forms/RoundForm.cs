using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace GUI
{
    public partial class RoundForm : Form
    {
        public RoundForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxS.Clear();
            if (textBoxR.Text == "")
            {
                MessageBox.Show("Поле пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r;
            double s = 0;
            if ((int.TryParse(textBoxR.Text, out r)))
            {
                if (r > 0)
                {
                    Round round = new Round(r);
                    s = round.ReturnSquare();
                    textBoxS.AppendText(s.ToString());
                }
                else
                {
                    MessageBox.Show("Значение поля \"Радиус\" должны быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
