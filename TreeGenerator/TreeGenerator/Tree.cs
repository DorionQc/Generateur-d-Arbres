using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TreeGenerator
{
    public enum Direction
    {
        XY,
        XZ,
        ZY
    };
    class Tree : Branch
    {
        protected float m_BranchAngle;

        protected _3DPoint m_Max;


        public _3DPointF r_NewBeginPoint { get; set; }
        public _3DPointF r_NewEndPoint { get; set; }
        public Random r_Random { get; set; }
        public float r_NewWidth { get; set; }
        public float r_NewLength { get; set; }
        public float r_NewAngleXY { get; set; }
        public float r_NewAngleXZ { get; set; }
        public double r_ran { get; set; }

        public bool Couleur { get; set; }

        public Tree(_3DPointF p, int Length, int Width, float AngleXY, float AngleXZ, int ChildrenCount, Branch Parent, Tree Base, float BranchingAngle, _3DPoint Max, bool Couleur) : base(p, Length, Width, AngleXY, AngleXZ, ChildrenCount, null, Base)
        {
            m_BranchAngle = BranchingAngle;
            r_Random = new Random();
            this.Couleur = Couleur;
            m_Position = new _3DPointF(Max.X / 2, 0, Max.Z / 2);
            m_Max = Max;

            Split();
        }

        public _3DPoint Max
        {
            get { return m_Max; }
        }

        public float BranchingAngle
        {
            get { return m_BranchAngle; }
        }

        public override void Draw(Graphics g, Direction dir, Size PanelSize)
        {
            base.Draw(g, dir, PanelSize);

            const float Offset = -10;

            Func<Leaf, Leaf, int> SortLeafX = delegate (Leaf f1, Leaf f2)
            {
                float X1;
                float X2;
                float Offset1 = 0;
                float Offset2 = 0;

                if (f1 is Branch)
                {
                    Branch f = (Branch)f1;
                    _3DPointF EndPoint = f.EndPoint;
                    if (f.Length > 0.06 * Max.Y && f.Width >= 0.03 * Max.Y)
                    {
                        Offset1 = Offset;
                    }
                    if (EndPoint.X > f1.Position.X)
                        X1 = EndPoint.X;
                    else
                        X1 = f1.Position.X;
                }
                else
                    X1 = f1.Position.X;

                if (f2 is Branch)
                {
                    Branch f = (Branch)f2;
                    _3DPointF EndPoint = f.EndPoint;
                    if (f.Length > 0.06 * Max.Y && f.Width >= 0.03 * Max.Y)
                    {
                        Offset2 = Offset;
                    }
                    if (EndPoint.X > f2.Position.X)
                        X2 = EndPoint.X;
                    else
                        X2 = f2.Position.X;
                }
                else
                    X2 = f2.Position.X;

                return (X1 + Offset1).CompareTo(X2 + Offset2);
            };

            Func<Leaf, Leaf, int> SortLeafY = delegate (Leaf f1, Leaf f2)
            {
                float Y1;
                float Y2;
                float Offset1 = 0;
                float Offset2 = 0;

                if (f1 is Branch)
                {
                    Branch f = (Branch)f1;
                    _3DPointF EndPoint = f.EndPoint;
                    if (f.Length > 0.06 * Max.Y && f.Width >= 0.03 * Max.Y)
                    {
                        Offset1 = Offset;
                    }
                    if (EndPoint.Y > f1.Position.Y)
                        Y1 = EndPoint.Y;
                    else
                        Y1 = f1.Position.Y;
                }
                else
                    Y1 = f1.Position.Y;

                if (f2 is Branch)
                {
                    Branch f = (Branch)f2;
                    _3DPointF EndPoint = f.EndPoint;
                    if (f.Length > 0.06 * Max.Y && f.Width >= 0.03 * Max.Y)
                    {
                        Offset2 = Offset;
                    }
                    if (EndPoint.Y > f2.Position.Y)
                        Y2 = EndPoint.Y;
                    else
                        Y2 = f2.Position.Y;
                }
                else
                    Y2 = f2.Position.Y;

                return (Y1 + Offset1).CompareTo(Y2 + Offset2);
            };

            Func<Leaf, Leaf, int> SortLeafZ = delegate (Leaf f1, Leaf f2)
            {
                float Z1;
                float Z2;
                float Offset1 = 0;
                float Offset2 = 0;

                if (f1 is Branch)
                {
                    Branch f = (Branch)f1;
                    _3DPointF EndPoint = f.EndPoint;
                    if (f.Length > 0.06 * Max.Z && f.Width >= 0.03 * Max.Z)
                    {
                        Offset1 = Offset;
                    }
                    if (EndPoint.Z > f1.Position.Z)
                        Z1 = EndPoint.Z;
                    else
                        Z1 = f1.Position.Z;
                }
                else
                    Z1 = f1.Position.Z;

                if (f2 is Branch)
                {
                    Branch f = (Branch)f2;
                    _3DPointF EndPoint = f.EndPoint;
                    if (f.Length > 0.06 * Max.Z && f.Width >= 0.03 * Max.Z)
                    {
                        Offset2 = Offset;
                    }
                    if (EndPoint.Z > f2.Position.Z)
                        Z2 = EndPoint.Z;
                    else
                        Z2 = f2.Position.Z;
                }
                else
                    Z2 = f2.Position.Z;

                return (Z1 + Offset1).CompareTo(Z2 + Offset2);
            };

            List<Leaf> ToDraw = new List<Leaf>();
            List<Leaf[]> Current = new List<Leaf[]> { m_Children };
            List<Leaf[]> Next = new List<Leaf[]>();

            while (Current.Any())
            {
                for (int i = 0; i < Current.Count; i++)
                {
                    foreach (Leaf f in Current[i])
                    {
                        //f.Draw(g, dir, PanelSize);
                        if (f is Branch && ((Branch)f).HasSplit)
                        {
                            Next.Add(((Branch)f).Children);
                            ToDraw.Add(f);
                        }
                    }
                }
                Current = Next;
                Next = new List<Leaf[]>();
            }

            switch (dir)
            {
                default:
                case Direction.XY:
                    ToDraw.Sort((x, y) => SortLeafZ(x, y));
                    break;
                case Direction.XZ:
                    ToDraw.Sort((x, y) => SortLeafY(x, y));
                    break;
                case Direction.ZY:
                    ToDraw.Sort((x, y) => SortLeafX(x, y));
                    break;
            }

            foreach (Leaf f in ToDraw)
            {
                Application.DoEvents();
                f.Draw(g, dir, PanelSize);
            }



        }

        public override Tree Base
        {
            get
            {
                return this;
            }
        }
    }
}
