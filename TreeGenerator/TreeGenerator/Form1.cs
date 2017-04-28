using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TreeGenerator
{
    public partial class Form1 : Form
    {
        Tree m_Tree;
        Bitmap[] m_Images;
        public Form1()
        {
            InitializeComponent();
            m_Images = new Bitmap[3];
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            m_Images = new Bitmap[3];
            float Zenith = 90 - ((int)numAngle.Value) * (float)(r.NextDouble() * 2 - 1);
            float Azimuth = 360 * (float)r.NextDouble();

            Zenith = _3DPointF.ToRad(Zenith);
            Azimuth = _3DPointF.ToRad(Azimuth);

            int Length = (int)numHeight.Value;

            m_Tree = new Tree(new _3DPoint((int)numX.Value / 2, 0, (int)numZ.Value / 2), Length, (int)numWidth.Value, Zenith, Azimuth,
                (int)numBranchNumber.Value, null, null, _3DPointF.ToRad((int)numBranchAngle.Value),
                new _3DPoint((int)numX.Value, (int)numY.Value, (int)numZ.Value), cbCouleur.Checked);
            panelXY.Refresh();
            panelXZ.Refresh();
            panelZY.Refresh();
        }

        private void panelXY_Paint(object sender, PaintEventArgs e)
        {
            if (m_Tree != null)
            {
                m_Tree.Draw(e.Graphics, Direction.XY, ((OptPanel)sender).Size);
            }
        }

        private void panelXZ_Paint(object sender, PaintEventArgs e)
        {
            if (m_Tree != null)
            {
                m_Tree.Draw(e.Graphics, Direction.XZ, ((OptPanel)sender).Size);
            }
        }

        private void panelZY_Paint(object sender, PaintEventArgs e)
        {
            if (m_Tree != null)
            {
                m_Tree.Draw(e.Graphics, Direction.ZY, e.ClipRectangle.Size);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            panelXY.Refresh();
            panelZY.Refresh();
            panelXZ.Refresh();
        }

        private void cbDoubleBuffer_CheckedChanged(object sender, EventArgs e)
        {
            panelXY.DoubleBuffered = ((CheckBox)sender).Checked;
            panelXZ.DoubleBuffered = ((CheckBox)sender).Checked;
            panelZY.DoubleBuffered = ((CheckBox)sender).Checked;
        }
    }

    public class OptPanel : Panel
    {

        public new bool DoubleBuffered
        {
            set { SetStyle(ControlStyles.OptimizedDoubleBuffer, value); }
            get { return GetStyle(ControlStyles.OptimizedDoubleBuffer); }
        }

        public OptPanel() : base()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
