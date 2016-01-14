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
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxS.Clear();
            if ((textBoxB.Text == "") && (textBoxH.Text == ""))
            {
                MessageBox.Show("Значения полей не введены.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (textBoxB.Text == "")
                {
                    MessageBox.Show("Значение поля \"Основание\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (textBoxH.Text == "")
                    {
                        MessageBox.Show("Значение поля \"Высота\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            int b, h;
            double s;
            if (int.TryParse(textBoxB.Text, out b))
            {
                if (b > 0)
                {
                    if (int.TryParse(textBoxH.Text, out h))
                    {
                        if (h > 0)
                        {
                            Triangle triangle = new Triangle(b, h);
                            s = triangle.ReturnSquare();
                            textBoxS.AppendText(s.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Значение поля \"Высота\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Значение поля \"Высота\" было введенно некорректно.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Значение поля \"Основание\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Значение поля \"Основание\" было введенно некорректно.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
