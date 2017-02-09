using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint;

namespace Modelling_signals
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxSwitchMetod.SelectedItem = "NRZ";
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
            
            paintGraphics paint = new paintGraphics(e, textBoxBinStaffNumber.Text.Length > 0 ? textBoxBinStaffNumber.Text : textBoxBinNumber.Text);
            paint.paintAxis();
            #region govnokod
            //if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "NRZ") paint.paintNRZ();
            //else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "NRZI(1)") paint.paintNRZI(true);
            //else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "NRZI(0)") paint.paintNRZI(false);
            //else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "RZ") paint.paintRZ();
            //else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "AMI") paint.paintAMI();
            //else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "Manchester") paint.paintManchester();
            //else if (Convert.ToString(comboBoxSwitchMetod.SelectedItem) == "2B1Q") paint.paint2B1Q();
            #endregion
            //
            string selectMethod = comboBoxSwitchMetod.SelectedItem.ToString();

            switch (selectMethod)
            {
                case "NRZ": paint.paintNRZ(); break;
                case "NRZI(1)": paint.paintNRZI(true); break;
                case "NRZI(0)": paint.paintNRZI(false); break;
                case "RZ": paint.paintRZ(); break;
                case "AMI": paint.paintAMI(); break;
                case "Manchester": paint.paintManchester(); break;
                case "2B1Q": paint.paint2B1Q(); break;
            }
        }

        private void textBoxSizeStaffing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            pictureBox.Size = new Size((textBoxBinStaffNumber.Text.Length > 0 ? textBoxBinStaffNumber.Text.Length : textBoxBinNumber.Text.Length) * 40 + 20, 80);
            pictureBox.Invalidate();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (textBoxSizeStaffing.Text.Length > 0)
            {
                string tempS1 = "";
                for (int i = 0; i < Convert.ToInt32(textBoxSizeStaffing.Text); i++)
                    tempS1 += '1';
                string tempS2 = tempS1 + '0';

                textBoxBinStaffNumber.Text = textBoxBinNumber.Text.Replace(tempS1, tempS2);
                int lengBin = textBoxBinStaffNumber.Text.Length - textBoxBinNumber.Text.Length;

                string temp = "";
                for (int i = 0; i < 8 - lengBin; i++)
                {
                    temp += '0';
                }
                textBoxBinStaffNumber.Text = textBoxBinStaffNumber.Text.Insert(textBoxBinStaffNumber.Text.Length - lengBin, temp);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSizeStaffing.Text = "";
            textBoxBinStaffNumber.Text = "";
        }
    }
}