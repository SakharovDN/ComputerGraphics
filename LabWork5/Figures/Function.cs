//namespace LabWork5.Figures
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Drawing;

//    public class Function : Figure
//    {
//        #region Methods

//        protected override List<Line> GetLines()
//        {
//            var lines = new List<Line>();
//            var points = new List<PointF>();

//            for (int i = 0; i < MatrixPoints.GetLength(0); i++)
//            {
//                if (i % 60 == 0)
//                {
//                    if (i != 0)
//                    {
//                        lines.Add(new Line(points));
//                        points = new List<PointF>
//                        {
//                            RowToPoint(i)
//                        };
//                        continue;
//                    }
//                }
//                points.Add(RowToPoint(i));
//            }

//            return lines;
//        }

//        protected override void SetDefaultPoints()
//        {
//            MatrixPoints = new float[3600, 4];
//            int counter = 0;

//            for (int i = -150; i < 150; i += 5)
//            {
//                for (int j = -150; j < 150; j += 5)
//                {
//                    MatrixPoints[counter, 0] = i;
//                    MatrixPoints[counter, 1] = j;
//                    MatrixPoints[counter, 2] = (float)(Math.Pow(i, 2) - Math.Pow(j, 2));
//                    MatrixPoints[counter, 3] = 1;
//                    counter++;
//                }
//            }
//        }

//        #endregion
//    }
//}
