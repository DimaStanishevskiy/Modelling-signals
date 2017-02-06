using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TZI_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(textBoxBinNumber.Text.Length * 40 + 20, 80);
            pictureBox.Invalidate();
        }

        private void textBoxBinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dictionary<char, string> toBin = new Dictionary<char, string>()
            {
                {'0', "0000" }, {'1', "0001" }, {'2', "0010" }, {'3', "0011" },
                {'4', "0100" }, {'5', "0101" }, {'6', "0110" }, {'7', "0111" },
                {'8', "1000" }, {'9', "1001" }, {'A', "1010" }, {'B', "1011" },
                {'C', "1100" }, {'D', "1101" }, {'E', "1110" }, {'F', "1111" },
            };

            if (e.KeyChar >= 'a' && e.KeyChar <= 'f')
            {
                e.KeyChar = (char)(e.KeyChar - 32);
            }
            if (char.IsNumber(e.KeyChar) ||  e.KeyChar >= 'A' && e.KeyChar <= 'F')
            {
                textBoxBinNumber.Text += toBin[e.KeyChar];
                return;
            }
            if (e.KeyChar == '\b')
            {
                if(textBoxBinNumber.Text.Length > 0)
                textBoxBinNumber.Text = textBoxBinNumber.Text.Remove(textBoxBinNumber.Text.Length - 4, 4);
                return;
            }

            e.Handled = true;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            //Graphics graphics = pictureBox.CreateGraphics();
            Pen graphic = new Pen(Color.FromArgb(255, 0, 0));
            Pen axis = new Pen(Color.FromArgb(0, 0, 0));
            Font font = new Font("Arials", 14);
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0));
            axis.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            int position = 10;

            if (textBoxBinNumber.Text.Length != 0)
            {
                e.Graphics.DrawLine(axis, 0, 30, textBoxBinNumber.Text.Length * 40 + 20, 30);
                e.Graphics.DrawLine(axis, position, 0, position, 60);
            }

            for(int i = 0; i < textBoxBinNumber.Text.Length; i++)
            {
                e.Graphics.DrawLine(axis, position, 0, position, 60);
                if (textBoxBinNumber.Text[i] == '0')
                {
                    e.Graphics.DrawLine(graphic, position, 30, position, 50);
                    e.Graphics.DrawLine(graphic, position, 50, position + 20, 50);
                    e.Graphics.DrawLine(graphic, position + 20, 50, position + 20, 30);
                    e.Graphics.DrawString("0", font, brush, position + 10, 60);
                }
                else
                {
                    e.Graphics.DrawLine(graphic, position, 30, position, 10);
                    e.Graphics.DrawLine(graphic, position, 10, position + 20, 10);
                    e.Graphics.DrawLine(graphic, position + 20, 10, position + 20, 30);
                    e.Graphics.DrawString("1", font, brush, position + 10, 60);

                }
                e.Graphics.DrawLine(graphic, position + 20, 30, position + 40, 30);

                position += 40;
                
            }

        }
    }
}
