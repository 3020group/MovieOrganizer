using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class ScatterPlot : Panel
    {
        private int lowerYear;
        private int higherYear;
        private int lowerPop;
        private int higherPop;
        private int sizeY;
        private int sizeX;
        private int dTop;
        private int dBot;
        private int dLeft;
        private int tickSize;
        private int tickSpaceX;
        private int tickSpaceY;
        private int nX;
        private int nY;
        private System.Drawing.Point origin;
        private Boolean supressDraw;

        public ScatterPlot()
        {
            InitializeComponent();
            setupPlot();
        }

        public ScatterPlot(IContainer container)
        {
            container.Add(this);
            InitializeComponent();

            lowerYear = 1900;
            higherYear = 2000;

            lowerPop = 0;
            higherPop = 10;

            setupPlot();
        }

        private void setupPlot()
        {
            this.Controls.Clear();

           
            nY = (higherPop - lowerPop);
            nX = (((higherYear - lowerYear) / 10));
            sizeY = getSizeY();
            sizeX = getSizeX();
            dTop = 20;
            dBot = this.Size.Height - sizeY - dTop;
            dLeft = 70;
            tickSize = 20;
            tickSpaceX = sizeX/nX;
            tickSpaceY = sizeY / nY;

            origin = new System.Drawing.Point(dLeft,dTop+sizeY);

            Refresh();
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Console.WriteLine("hello");
            drawAxis();

        }

        private void drawAxis()
        {
            this.Controls.Clear();

            System.Drawing.Pen p;
            p = new System.Drawing.Pen(System.Drawing.Color.Black,5);
            System.Drawing.Graphics g = this.CreateGraphics();

            //draw the x-axis
            g.DrawLine(p, dLeft, dTop+sizeY, dLeft + sizeX, dTop+sizeY);

            //draw the y axis
            g.DrawLine(p, dLeft, dTop, dLeft, dTop + sizeY);
            
            //draw the first x label and line
            int labelNumber = (lowerYear);
            string labelText = labelNumber.ToString();
            Font f = new Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Size textSize = TextRenderer.MeasureText(labelText, f);
            Point location = new Point(origin.X - (textSize.Width / 2), origin.Y + tickSize + 2);
            g.DrawString(labelText, f, new SolidBrush(Color.Black), location);

            g.DrawLine(p, origin.X, origin.Y + (tickSize / 2), origin.X  , origin.Y - (tickSize / 2));


            //draw ticks and add labels for x axis
            for (int i=0;i< nX;i++)
            {
                labelNumber = lowerYear + (10 * (i + 1));
                labelText = labelNumber.ToString();
                f = new Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textSize = TextRenderer.MeasureText(labelText, f);
                location = new Point(origin.X + ((i + 1) * tickSpaceX) - (textSize.Width / 2), origin.Y + tickSize + 2);
                g.DrawString(labelText, f, new SolidBrush(Color.Black), location);

                g.DrawLine(p,origin.X+((i+1)*tickSpaceX),origin.Y+(tickSize/2), origin.X + ((i+1) * tickSpaceX),origin.Y-(tickSize/2));
            }

            //draw the first y label and line
            labelText = (lowerPop).ToString();
            f = new Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textSize = TextRenderer.MeasureText(labelText, f);
            location = new Point(origin.X - tickSize - 10, origin.Y - 7);
            g.DrawString(labelText, f, new SolidBrush(Color.Black), location);

            g.DrawLine(p, dLeft + (tickSize / 2), origin.Y , dLeft - (tickSize / 2), origin.Y);

            //draw ticks on the y axis
            for (int i=0;i< nY;i++)
            {
                labelText = (i+1+lowerPop).ToString();
                f = new Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textSize = TextRenderer.MeasureText(labelText, f);
                location = new Point(origin.X - tickSize-10, origin.Y - ((i+1)*tickSpaceY)-7);
                g.DrawString(labelText, f, new SolidBrush(Color.Black), location);

                g.DrawLine(p, dLeft+(tickSize/2), origin.Y - ((i + 1) * tickSpaceY), dLeft-(tickSize/2), origin.Y - ((i + 1) * tickSpaceY));
            }



            p.Dispose();
            g.Dispose();

        }

        private int getSizeY()
        {
            int size = 500;

            while(size % nY != 0)
            {
                size++;
            }

            return size;
        }

        private int getSizeX()
        {
            int size = 610;

            while (size % nX != 0)
            {
                size++;
            }

            return size;
        }
        
        public void drawMovies(List<Movie> movies,Dictionary<string,Color> colorMap,List<string> genres)
        {
            int lX;
            int lY;

            foreach (Movie m in movies)
            {
                Panel p = new Panel();
                p.Size = new System.Drawing.Size(7, 7);
                lX = getXLocation(m.Year);
                lY = getYLocation(m.Rating);
                p.Location = new System.Drawing.Point(lX, lY);
                p.BackColor = getColor(colorMap,genres,m);
                this.Controls.Add(p);
            }
            
        }

        public Color getColor(Dictionary<string,Color> colorMap,List<string> genres, Movie m)
        {

            foreach(string u in m.Genres)
            {
                foreach(string v in genres)
                {
                    if(u.Equals(v))
                    {
                        return colorMap[v];
                    }
                }
            }

            return Color.Black;
        }

        private int getXLocation(int year)
        {
            decimal d = year / 10;
            double offset = 0;

            int baseLocation = (int)Math.Floor(d);
            baseLocation = baseLocation - (lowerYear/10);
            baseLocation *= tickSpaceX;

            if(year%10!=0)
            {
                offset = tickSpaceX - (tickSpaceX / (year % 10));
            }

            return baseLocation+(int)offset+origin.X;
        }

        private int getYLocation(int rating)
        {
            return origin.Y-(rating * tickSpaceY);
        }

        public void changeYearRange(int newLowest,int newHighest)
        {
            lowerYear = newLowest;
            higherYear = newHighest;

            setupPlot();
        }

        public void changeRatingRange(int newLowest, int newHighest)
        {
            lowerPop = newLowest;
            higherPop = newHighest;

            setupPlot();
        }

    }
}
