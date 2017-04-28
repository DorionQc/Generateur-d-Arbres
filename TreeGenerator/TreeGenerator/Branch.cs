using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace TreeGenerator
{
    class Branch : Leaf
    {
        protected float m_Length;
        protected float m_Width;
        protected float m_AngleXY;
        protected float m_AngleXZ;
        protected Leaf[] m_Children;
        protected bool m_HasSplit;

        public Branch(_3DPointF p, float Length, float Width, float AngleXY, float AngleXZ, int ChildrenCount, Branch Parent, Tree Base) : base(p, Parent, Base)
        {
            m_Length = Length;
            m_AngleXY = AngleXY;
            m_AngleXZ = AngleXZ;
            m_Width = Width;
            if (ChildrenCount < 0)
                ChildrenCount = 0;
            m_Children = new Leaf[ChildrenCount];
            m_HasSplit = false;
        }

        public float Length
        {
            get { return m_Length; }
            set
            {
                if (value > 0)
                    m_Length = value;
                else
                    m_Length = 0;
            }
        }

        public float Width
        {
            get { return m_Width; }
            set
            {
                if (value > 0)
                    m_Width = value;
                else
                    m_Width = 0;
            }
        }

        public float AngleXY
        {
            get { return m_AngleXY; }
            set { m_AngleXY = value; }
        }
        public float AngleXZ
        {
            get { return m_AngleXZ; }
            set { m_AngleXZ = value; }
        }


        public Leaf this[int Index]
        {
            get
            {
                if (Index < m_Children.Length && Index >= 0)
                    return m_Children[Index];
                return null;
            }
        }

        public Leaf[] Children
        {
            get { return m_Children; }
        }

        public _3DPointF EndPoint
        {
            get
            {
                return new _3DPointF(
                m_Position.X + (float)(m_Length * Math.Cos(m_AngleXY) * Math.Cos(m_AngleXZ)),
                m_Position.Y + (float)(m_Length * Math.Sin(m_AngleXY)),
                m_Position.Z + (float)(m_Length * Math.Sin(m_AngleXZ) * Math.Cos(m_AngleXY))
                );
            }
        }

        public bool HasSplit
        {
            get { return m_HasSplit; }
        }

        public override void Draw(Graphics graph, Direction dir, Size PanelSize)
        {
            _3DPointF EndPoint = this.EndPoint;
            PointF DrawPoint1, DrawPoint2;
            Pen p;
            int r, g, b;
            r = (int)(m_Position.X * 128 / Base.Max.X);
            if (r > 128)
                r = 128;
            else if (r < 0)
                r = 0;
            r += 64;
            g = (int)(m_Position.Y * 128 / Base.Max.Y);
            if (g > 128)
                g = 128;
            else if (g < 0)
                g = 0;
            g += 96;
            b = (int)(m_Position.Z * 128 / Base.Max.Z);
            if (b > 128)
                b = 128;
            else if (b < 0)
                b = 0;
            b += 64;
            if (Length > 0.06 * Base.Max.Y && m_Width >= 0.03 * Base.Max.Y)
            {
                p = new Pen(Color.FromArgb(92, 61, 14), m_Width / (0.02f * Base.Max.Y));
            }
            else
            {
                p = new Pen(Color.FromArgb(Base.Couleur ? r : 0, g, Base.Couleur ? b : 0),
                m_Width * (float)PanelSize.Height / Base.Max.Y);
            }

            switch (dir)
            {
                default:
                case Direction.XY:
                    DrawPoint1 = new PointF(m_Position.X, Base.Max.Y - m_Position.Y).ToPanelSize(Base.Max.X, Base.Max.Y, PanelSize.Width, PanelSize.Height);
                    DrawPoint2 = new PointF(EndPoint.X, Base.Max.Y - EndPoint.Y).ToPanelSize(Base.Max.X, Base.Max.Y, PanelSize.Width, PanelSize.Height);
                    break;
                case Direction.XZ:
                    DrawPoint1 = new PointF(m_Position.X, m_Position.Z).ToPanelSize(Base.Max.X, Base.Max.Z, PanelSize.Width, PanelSize.Height);
                    DrawPoint2 = new PointF(EndPoint.X, EndPoint.Z).ToPanelSize(Base.Max.X, Base.Max.Z, PanelSize.Width, PanelSize.Height);
                    break;
                case Direction.ZY:
                    DrawPoint1 = new PointF(m_Position.Z, Base.Max.Y - m_Position.Y).ToPanelSize(Base.Max.Z, Base.Max.Y, PanelSize.Width, PanelSize.Height);
                    DrawPoint2 = new PointF(EndPoint.Z, Base.Max.Y - EndPoint.Y).ToPanelSize(Base.Max.Z, Base.Max.Y, PanelSize.Width, PanelSize.Height);
                    break;
            }
            graph.DrawLine(p, DrawPoint1, DrawPoint2);
            p.Dispose();
            /*if (m_HasSplit)
                foreach (Leaf f in m_Children)
                    f.Draw(g, dir);*/
        }

        public void Split()
        {
            if (m_HasSplit)
                return;
            m_HasSplit = true;

            Base.r_NewEndPoint = EndPoint;

            for (int i = 0; i < m_Children.Length; i++)
            {
                Base.r_NewWidth = (float)(m_Width / 2 * (1 + Base.r_Random.NextDouble() / 2));

                Base.r_NewLength = (float)((0.5 + (Base.r_Random.NextDouble() / 2)) * m_Length);
                if (Base.r_NewWidth != 0 && Base.r_NewLength != 0 && Base.r_NewWidth / (float)Base.r_NewLength < 0.1)
                {
                    Base.r_NewLength /= 10;
                }
                Base.r_NewAngleXY = (float)(m_AngleXY + Base.BranchingAngle * (1 - (Base.r_Random.NextDouble() * 2)));
                Base.r_NewAngleXZ = (float)(m_AngleXZ + Base.BranchingAngle * (1 - (Base.r_Random.NextDouble() * 2)));

                Base.r_ran = 0.5 + (Base.r_Random.NextDouble() / 2);
                Base.r_NewBeginPoint = new _3DPointF(
                    (float)(m_Position.X + Base.r_ran * (Base.r_NewEndPoint.X - m_Position.X)),
                    (float)(m_Position.Y + Base.r_ran * (Base.r_NewEndPoint.Y - m_Position.Y)),
                    (float)(m_Position.Z + Base.r_ran * (Base.r_NewEndPoint.Z - m_Position.Z))
                    );

                if (Base.r_NewWidth <= 0.01 * Base.Max.Y || Base.r_NewLength <= 0.02 * Base.Max.Y)
                {
                    m_Children[i] = new Leaf(Base.r_NewBeginPoint, this, Base);
                }
                else
                {
                    m_Children[i] = new Branch(Base.r_NewBeginPoint,
                        Base.r_NewLength, Base.r_NewWidth, Base.r_NewAngleXY, Base.r_NewAngleXZ, (int)(3.0 * Base.Children.Length / 4 + Base.Children.Length * (Base.r_NewLength / (float)Base.Length) / 4), this, Base);
                }
            }
            Application.DoEvents();
            foreach (Leaf f in m_Children)
            {
                if (f is Branch)
                {
                    ((Branch)f).Split();
                }
            }

            return;
        }

    }
}
