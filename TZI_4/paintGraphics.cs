using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint
{
    class paintGraphics
    {
        const int top = 10;
        const int semiTop = 20;
        const int mid = 30;
        const int semiBottom = 40;
        const int bottom = 50;
        const int tact = 40;
        const int stact = tact / 2;
        const int padding = 10;
        const int posSymb = 60;
        PaintEventArgs e;
        string binNumber;
        Pen axis = new Pen(Color.FromArgb(0, 0, 0));
        Pen graphic = new Pen(Color.FromArgb(255, 0, 0));
        Font font = new Font("Arials", 14);
        SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0));

        public paintGraphics(PaintEventArgs e, string binNumber)
        {
            this.e = e;
            this.binNumber = binNumber;
            axis.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        public void paintAxis()
        { 
            if (binNumber.Length != 0)
            {
                e.Graphics.DrawLine(axis, 0, mid, binNumber.Length * tact + 2 * padding, mid);
                for (int i = 0; i <= binNumber.Length; i++)
                    e.Graphics.DrawLine(axis, padding + tact * i, 0, padding + tact * i, bottom + padding);
            }
        }

        public void paintNRZ()
        {
            for (int i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == '0')
                { 
                    e.Graphics.DrawLine(graphic, i * tact + padding, top, i * tact + tact + padding, top);
                    e.Graphics.DrawString("0", font, brush, i * tact + stact, posSymb);
                }
                else
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, bottom, i * tact + tact + padding, bottom);
                    e.Graphics.DrawString("1", font, brush, i * tact + stact, posSymb);

                }
            }
            for (int i = 1; i < binNumber.Length; i++)
                if (binNumber[i] != binNumber[i - 1])
                    e.Graphics.DrawLine(graphic, i * tact + padding, bottom, i * tact + padding, top);
        }

        public void paintNRZI(bool type)
        {
            char switchSignal;
            if (type) switchSignal = '1';
            else switchSignal = '0';

            bool ifTop = false;
            for (int i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == switchSignal)
                {
                    ifTop = ifTop ^ true;
                    e.Graphics.DrawLine(graphic, i * tact + padding, bottom, i * tact + padding, top);
                }
                if (ifTop)
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, top, i * tact + tact + padding, top);

                }
                else
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, bottom, i * tact + tact + padding, bottom);
                }
                e.Graphics.DrawString(Convert.ToString(binNumber[i]), font, brush, i * tact + stact, posSymb);
            }
        }

        public void paintRZ()
        {

            for (int i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == '0')
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, mid, i * tact + padding, bottom);
                    e.Graphics.DrawLine(graphic, i * tact + padding, bottom, i * tact + stact + padding, bottom);
                    e.Graphics.DrawLine(graphic, i * tact + stact + padding, bottom, i * tact + stact + padding, mid);
                    e.Graphics.DrawString("0", font, brush, i * tact + stact, posSymb);
                }
                else
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, mid, i * tact + padding, top);
                    e.Graphics.DrawLine(graphic, i * tact + padding, top, i * tact + stact + padding, top);
                    e.Graphics.DrawLine(graphic, i * tact + stact + padding, top, i * tact + stact + padding, mid);
                    e.Graphics.DrawString("1", font, brush, i * tact + stact, posSymb);

                }
                e.Graphics.DrawLine(graphic, i * tact + stact + padding, mid, (i + 1) * tact + padding, mid);
            }
        }

        public void paintAMI()
        {

            bool ifTop = true;
            for (int i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == '1')
                    ifTop = ifTop ^ true;

                if (binNumber[i] == '0')
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, mid, i * tact + tact + padding, mid);

                }
                else
                {
                    int topOrBottom = ifTop ? top : bottom;
                    e.Graphics.DrawLine(graphic, i * tact + padding, topOrBottom, i * tact + tact + padding, topOrBottom);
                    e.Graphics.DrawLine(graphic, i * tact + padding, topOrBottom, i * tact + padding, mid);
                    e.Graphics.DrawLine(graphic, (i + 1) * tact + padding, topOrBottom, (i + 1) * tact + padding, mid);
                }
                e.Graphics.DrawString(Convert.ToString(binNumber[i]), font, brush, i * tact + stact, posSymb);
            }
        }

        public void paintManchester()
        {
            bool ifHight;
            for (int i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == '1') ifHight = true;
                else ifHight = false;

                int part1 = ifHight ? bottom : top;
                int part2 = ifHight ? top : bottom;
                
                e.Graphics.DrawLine(graphic, i * tact + padding, part1, i * tact + stact + padding, part1);
                e.Graphics.DrawLine(graphic, i * tact + stact + padding, top, i * tact + stact + padding, bottom);
                e.Graphics.DrawLine(graphic, i * tact + stact + padding, part2, (i + 1) * tact + padding, part2);
                e.Graphics.DrawString(Convert.ToString(binNumber[i]), font, brush, i * tact + stact, posSymb);
            }
            for(int i = 1; i < binNumber.Length; i++)
                if(binNumber[i] == binNumber[i - 1])
                    e.Graphics.DrawLine(graphic, i * tact + padding, top, i * tact + padding, bottom);

        }

        public void paint2B1Q()
        {
            int[] mLvl = new int[binNumber.Length / 2];
            for(int i = 0; i < binNumber.Length; i+= 2)
            {
                mLvl[i / 2] = binNumber[i] == '1' ?
                    (binNumber[i + 1] == '0' ? top : semiTop)
                    : (binNumber[i + 1] == '0' ? bottom : semiBottom);

                e.Graphics.DrawLine(graphic, i * stact + padding, mLvl[i / 2], (i + 2) * stact + padding, mLvl[i / 2]);

                e.Graphics.DrawString(Convert.ToString(binNumber[i]), font, brush, i * stact + padding, posSymb);
                e.Graphics.DrawString(Convert.ToString(binNumber[i + 1]), font, brush, (i + 1) * stact + padding, posSymb);
            }

            for (int i = 1; i < binNumber.Length / 2; i++)
                e.Graphics.DrawLine(graphic, i * tact + padding, mLvl[i - 1], i * tact + padding, mLvl[i]);
        }
    }
}