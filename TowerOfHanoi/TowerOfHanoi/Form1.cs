using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class mainWindow : Form
    {
        private Rectangle[] pegLoc = new Rectangle[3];
        private Stack<int>[] pegs = new Stack<int>[3];
        private Rectangle movingDisk;
        private int numDisks;
        private int width;
        private int peg1, peg2, peg3;
        private bool move = false;
        private Thread t;

        public mainWindow(int num)
        {
            numDisks = num;
            width = numDisks * 20;
            this.Paint += new PaintEventHandler(mainWindow_Paint);
            InitializeHanoi();
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(Begin));
            t.Start();
            startButton.Enabled = false;
            suspendButton.Enabled = true;
            abortButton.Enabled = true;
        }

        private void Begin()
        {
            Solve(0, 2, 1, numDisks);
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            t.Resume();
            resumeButton.Enabled = false;
            suspendButton.Enabled = true;
        }

        private void suspendButton_Click(object sender, EventArgs e)
        {
            t.Suspend();
            suspendButton.Enabled = false;
            resumeButton.Enabled = true;
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            t.Abort();
            this.Close();
        }

        private void InitializeHanoi()
        {
            this.DoubleBuffered = true;
            CreatePegs();
            //DrawPegs(g);
            CreateDisks();
            //DrawDisks(g);
        }

        private void mainWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            //g = e.Graphics;
            DrawPegs(e.Graphics);
            DrawDisks(e.Graphics);
        }

        private void Solve(int src, int dest, int inter, int num)
        {
            //(src, dest);
            if (num == 1)
            {
                MoveDisk(src, dest);
            }

            else
            {
                Solve(src, inter, dest, num - 1);
                MoveDisk(src, dest);
                Solve(inter, dest, src, num - 1);
            }
        }

        private void CreatePegs()
        {
            for (int i = 0; i < 3; i++)
            {
                pegs[i] = new Stack<int>();
            }

            peg1 = 200;
            peg2 = 450;
            peg3 = 700;

            pegLoc[0] = new Rectangle(peg1 - 20 / 2, 200, 20, 200);
            pegLoc[1] = new Rectangle(peg2 - 20 / 2, 200, 20, 200);
            pegLoc[2] = new Rectangle(peg3 - 20 / 2, 200, 20, 200);
        }

        private void DrawPegs(Graphics g)
        {
            for (int i = 0; i < 3; i++)
            {
                g.FillRectangle(Brushes.Black, pegLoc[i]);
                g.DrawRectangle(Pens.Black, pegLoc[i]);
            }
        }

        private void CreateDisks()
        {
            for (int i = 0; i < numDisks; i++)
            {
                pegs[0].Push(width);
                width -= 20;
            }
        }

        private void DrawDisks(Graphics g)
        {
            int color = 0;
            Brush b;

            for (int i = 0; i < 3; i++)
            {
                int y = 370;

                foreach (int w in pegs[i].Reverse())
                {
                    Rectangle r = new Rectangle((pegLoc[i].X + 10) - (w / 2), y, w, 20);
                    b = GetColor(w);
                    g.FillRectangle(b, r);
                    g.DrawRectangle(Pens.Black, r);
                    y -= 20;
                    color++;
                }
            }

            if (move)
            {
                g.FillRectangle(GetColor(movingDisk.Width), movingDisk);
                g.DrawRectangle(Pens.Black, movingDisk);
            }
        }

        private Brush GetColor(int w)
        {
            Brush b;

            if (w == 160)
                b = Brushes.Red;

            else if (w == 140)
                b = Brushes.Orange;

            else if (w == 120)
                b = Brushes.Yellow;

            else if (w == 100)
                b = Brushes.YellowGreen;

            else if (w == 80)
                b = Brushes.Green;

            else if (w == 60)
                b = Brushes.LightBlue;

            else if (w == 40)
                b = Brushes.Blue;

            else
                b = Brushes.Violet;

            return b;
        }

        private void MoveDisk(int src, int dest)
        {
            int width = pegs[src].Pop();
            move = true;
            int y = pegLoc[src].Bottom - (pegs[src].Count + 1) * 42;
            int x = pegLoc[src].X + 10 - (width / 2);
            movingDisk = new Rectangle(x, y, width, 20);

            int xNew;
            int yNew = 100;
            AnimateUp(x, yNew);

            if (src < dest)
            {
                xNew = pegLoc[dest].X + 10 - width / 2;
                AnimateRight(xNew, yNew);
            }

            else
            {
                xNew = pegLoc[dest].X + 10 - width / 2;
                AnimateLeft(xNew, yNew);
            }

            yNew = pegLoc[dest].Bottom - (pegs[dest].Count + 1) * 25;
            AnimateDown(xNew, yNew);

            Invalidate();
            pegs[dest].Push(width);
        }

        private void AnimateUp(int xNew, int yNew)
        {
            while (movingDisk.Y > yNew)
            {
                Invalidate();
                Thread.Sleep(20);

                movingDisk.Y -= 10;
            }

            movingDisk.X = xNew;
            movingDisk.Y = yNew;
        }

        private void AnimateRight(int xNew, int yNew)
        {
            while (movingDisk.X < xNew)
            {
                Invalidate();
                Thread.Sleep(20);
                movingDisk.X += 10;
            }

            movingDisk.X = xNew;
            movingDisk.Y = yNew;
        }

        private void AnimateDown(int xNew, int yNew)
        {
            while (movingDisk.Y < yNew)
            {
                Invalidate();
                Thread.Sleep(20);
                movingDisk.Y += 10;
            }

            movingDisk.X = xNew;
            movingDisk.Y = yNew;
        }

        private void AnimateLeft(int xNew, int yNew)
        {
            while (movingDisk.X > xNew)
            {
                Invalidate();
                Thread.Sleep(20);
                movingDisk.X -= 10;
            }

            movingDisk.X = xNew;
            movingDisk.Y = yNew;
        }
    }
}
