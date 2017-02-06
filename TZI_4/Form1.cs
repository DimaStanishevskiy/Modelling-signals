using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using paint;

namespace Modelling_signals
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxSwitchMetod.SelectedItem = "NRZ";
        }

        

        private void resizeGraphics()
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
                resizeGraphics();
                return;
            }
            if (e.KeyChar == '\b')
            {
                if(textBoxBinNumber.Text.Length > 0)
                textBoxBinNumber.Text = textBoxBinNumber.Text.Remove(textBoxBinNumber.Text.Length - 4, 4);
                resizeGraphics();
                return;
            }

            e.Handled = true;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            paintGraphics paint = new paintGraphics(e, textBoxBinNumber.Text);
            paint.paintAxis();

            if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "NRZ") paint.paintNRZ();
            else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "diff. NRZ") paint.paintDiffNRZ();
            else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "NRZI") paint.paintNRZI();
            else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "RZ") paint.paintRZ();
            else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "AMI") paint.paintAMI();
            else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "Manchester") paint.paintManchester();
            else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "2B1Q") paint.paint2B1Q();
        }

        private void comboBoxSwitchMetod_SelectedIndexChanged(object sender, EventArgs e)
        {
            resizeGraphics();
        }
    }
}
