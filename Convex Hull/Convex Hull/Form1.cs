using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace Convex_Hull
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private List<Point> coor_Points = new List<Point>();

        private void bClear_Click(object sender, EventArgs e)
        {
            coor_Points = new List<Point>();
            this.Invalidate();
        }

        private void fMain_MouseDown(object sender, MouseEventArgs e)
        {
            coor_Points.Add(new Point(e.X, e.Y));
            this.Invalidate();
        }

        private void fMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Point pt in coor_Points)
            {
                e.Graphics.FillEllipse(Brushes.Cyan, pt.X - 3, pt.Y - 3, 7, 7);
            }
            ///////////////////////////////////////
            List<Point> hull = null;
            if (coor_Points.Count >= 3)
            {
                hull = Geometric.MakeConvexHull(coor_Points);
                foreach (Point pt in Geometric.g_NonCulledPoints)
                {
                    e.Graphics.FillEllipse(Brushes.White, pt.X - 3, pt.Y - 3, 7, 7);
                }
            }
            ///////////////////////////////////////
            foreach (Point pt in coor_Points)
            {
                e.Graphics.DrawEllipse(Pens.Black, pt.X - 3, pt.Y - 3, 7, 7);
            }
            ///////////////////////////////////////
            if (coor_Points.Count >= 3)
            {
                if(cboxMin.Checked == true)
                    e.Graphics.DrawPolygon(Pens.Red, Geometric.g_MinMaxCorners);
                if(cboxCulling.Checked == true)               
                    e.Graphics.DrawRectangle(Pens.Orange, Geometric.g_MinMaxBox);
                if (cboxConvex.Checked == true)
                {
                    Point[] hull_points = new Point[hull.Count];
                    hull.CopyTo(hull_points);
                    e.Graphics.DrawPolygon(Pens.Blue, hull_points);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
