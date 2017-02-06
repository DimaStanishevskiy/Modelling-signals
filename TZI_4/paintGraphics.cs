using System.Drawing;
using System.Windows.Forms;

namespace paint
{
    class paintGraphics
    {
        const int top = 50;
        const int secondTop = 40;
        const int mid = 30;
        const int secondBottom = 20;
        const int bottom = 10;
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
                    e.Graphics.DrawLine(axis, padding + tact * i, 0, padding + tact * i, top + padding);
            }
        }

        public void paintNRZ()
        {

        }

        public void paintDiffNRZ()
        {

        }

        public void paintNRZI()
        {

        }

        public void paintRZ()
        {

            for (int i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == '0')
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, mid, i * tact + padding, top);
                    e.Graphics.DrawLine(graphic, i * tact + padding, top, i * tact + stact + padding, top);
                    e.Graphics.DrawLine(graphic, i * tact + stact + padding, top, i * tact + stact + padding, mid);
                    e.Graphics.DrawString("0", font, brush, i * tact + stact, posSymb);
                }
                else
                {
                    e.Graphics.DrawLine(graphic, i * tact + padding, mid, i * tact + padding, bottom);
                    e.Graphics.DrawLine(graphic, i * tact + padding, bottom, i * tact + stact + padding, bottom);
                    e.Graphics.DrawLine(graphic, i * tact + stact + padding, bottom, i * tact + stact + padding, mid);
                    e.Graphics.DrawString("1", font, brush, i * tact + stact, posSymb);

                }
                e.Graphics.DrawLine(graphic, i * tact + stact + padding, mid, (i + 1) * tact + padding, mid);
            }
        }

        public void paintAMI()
        {

        }

        public void paintManchester()
        {

        }

        public void paint2B1Q()
        {

        }
    }
}
