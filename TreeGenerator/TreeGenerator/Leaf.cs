using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TreeGenerator
{
    class Leaf
    {
        protected _3DPointF m_Position;
        protected Branch m_Parent;
        protected Tree m_Base;

        public Leaf(_3DPointF p, Branch Parent, Tree Base)
        {
            m_Base = Base;
            m_Position = p;
            m_Parent = Parent;
        }

        public _3DPointF Position
        {
            get { return m_Position; }
            set { m_Position = value; }
        }

        public Branch Parent
        {
            get { return m_Parent; }
        }

        public virtual Tree Base
        {
            get { return m_Base; }
        }

        public virtual void Draw(Graphics graph, Direction dir, Size PanelSize)
        {
            PointF DrawPoint;
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
            Brush br = new SolidBrush(Color.FromArgb(r, g, b));
            switch (dir)
            {
                default:
                case Direction.XY:
                    DrawPoint = new PointF(m_Position.X, Base.Max.Y - m_Position.Y).ToPanelSize(Base.Max.X, Base.Max.Y, PanelSize.Width, PanelSize.Height);
                    break;
                case Direction.XZ:
                    DrawPoint = new PointF(m_Position.X, m_Position.Z).ToPanelSize(Base.Max.X, Base.Max.Z, PanelSize.Width, PanelSize.Height);
                    break;
                case Direction.ZY:
                    DrawPoint = new PointF(m_Position.Z, Base.Max.Y - m_Position.Y).ToPanelSize(Base.Max.Z, Base.Max.Y, PanelSize.Width, PanelSize.Height);
                    break;
            }
            graph.FillEllipse(br, DrawPoint.X, DrawPoint.Y, 5, 5);
            br.Dispose();
        }
    }
}
