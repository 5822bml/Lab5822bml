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
    public partial class QuadrateForm : Form
    {
        public QuadrateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxS.Clear();
            if ((textBoxA.Text == "") && (textBoxB.Text == ""))
            {
                MessageBox.Show("Значения полей не введены.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (textBoxA.Text == "")
                {
                    MessageBox.Show("Значение поля \"Сторона \"а\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (textBoxB.Text == "")
                    {
                        MessageBox.Show("Значение поля \"Сторона \"b\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            int a, b;
            double s = 0;
            if (int.TryParse(textBoxA.Text, out a))
            {
                if (a > 0)
                {
                    if (int.TryParse(textBoxB.Text, out b))
                    {
                        if (b > 0)
                        {
                            Quadrate quadrate = new Quadrate(a, b);
                            s = quadrate.ReturnSquare();
                            textBoxS.AppendText(s.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Значение поля \"сторона \"b\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Значение поля \"сторона \"b\" было введенно некорректно.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Значение поля \"сторона \"а\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Значение поля \"сторона \"а\" было введенно некорректно.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
