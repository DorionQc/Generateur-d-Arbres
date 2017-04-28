using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TreeGenerator
{

    public static class Extensions
    {
        public static PointF ToPanelSize(this PointF p, Size CurrentSize, Size PanelSize)
        {
            return p.ToPanelSize(CurrentSize.Width, CurrentSize.Height, PanelSize.Width, PanelSize.Height);
        }

        public static PointF ToPanelSize(this PointF p, int CurrentSizeX, int CurrentSizeY, int PanelSizeX, int PanelSizeY)
        {
            return new PointF(p.X * PanelSizeX / CurrentSizeX, p.Y * PanelSizeY / CurrentSizeY);
        }
    }
    public class _3DPoint
    {
        private int m_x;
        private int m_y;
        private int m_z;

        public static _3DPoint Zero
        {
            get { return new _3DPoint(0, 0, 0); }
        }

        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }

        public int Y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        public int Z
        {
            get { return m_z; }
            set { m_z = value; }
        }

        public _3DPoint()
        {
            m_x = 0;
            m_y = 0;
            m_z = 0;
        }

        public _3DPoint(int x, int y, int z)
        {
            m_x = x;
            m_y = y;
            m_z = z;
        }

        public static implicit operator _3DPointF(_3DPoint p)
        {
            return new _3DPointF(p.X, p.Y, p.Z);
        }

        public static _3DPoint operator +(_3DPoint p1, _3DPoint p2)
        {
            return new _3DPoint(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public static _3DPoint operator -(_3DPoint p1, _3DPoint p2)
        {
            return new _3DPoint(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }

        public float LengthTo(_3DPoint p2)
        {
            int dx = m_x - p2.X, dy = m_y - p2.Y, dz = m_z - p2.Z;
            return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public int LengthToSq(_3DPoint p2)
        {
            int dx = m_x - p2.X, dy = m_y - p2.Y, dz = m_z - p2.Z;
            return dx * dx + dy * dy + dz * dz;
        }

        public static double ToRad(int Angle)
        {
            return (Angle * Math.PI) / 180.0;
        }

        public _3DPoint SetLength(int Length)
        {
            int Max = Math.Max(Math.Max(m_x, m_y), m_z);
            float Ratio = Max / Length;
            m_x = (int)(m_x / Ratio);
            m_y = (int)(m_y / Ratio);
            m_z = (int)(m_z / Ratio);
            return this;
        }
    }

    public class _3DPointF
    {
        private float m_x;
        private float m_y;
        private float m_z;

        public static _3DPointF Zero
        {
            get { return new _3DPointF(0, 0, 0); }
        }

        public float X
        {
            get { return m_x; }
            set { m_x = value; }
        }

        public float Y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        public float Z
        {
            get { return m_z; }
            set { m_z = value; }
        }

        public _3DPointF()
        {
            m_x = 0;
            m_y = 0;
            m_z = 0;
        }

        public _3DPointF(float x, float y, float z)
        {
            m_x = x;
            m_y = y;
            m_z = z;
        }

        public static _3DPointF operator +(_3DPointF p1, _3DPointF p2)
        {
            return new _3DPointF(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public static _3DPointF operator -(_3DPointF p1, _3DPointF p2)
        {
            return new _3DPointF(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }

        public float LengthTo(_3DPointF p2)
        {
            float dx = m_x - p2.X, dy = m_y - p2.Y, dz = m_z - p2.Z;
            return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public float LengthToSq(_3DPointF p2)
        {
            float dx = m_x - p2.X, dy = m_y - p2.Y, dz = m_z - p2.Z;
            return dx * dx + dy * dy + dz * dz;
        }

        public static float ToRad(float Angle)
        {
            return (float)((Angle * Math.PI) / 180.0f);
        }

        public _3DPointF SetLength(float Length)
        {
            float Max = Math.Max(Math.Max(m_x, m_y), m_z);
            float Ratio = Max / Length;
            m_x /= Ratio;
            m_y /= Ratio;
            m_z /= Ratio;
            return this;
        }

        public override string ToString()
        {
            return String.Format("X = {0}, Y = {1}, Z = {2}", m_x, m_y, m_z);
        }
    }
}
