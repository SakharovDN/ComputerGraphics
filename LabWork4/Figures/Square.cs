namespace LabWork4.Figures
{
    using System.Collections.Generic;
    using System.Drawing;

    public class Square : Figure
    {
        #region Methods

        protected override List<Line> GetLines()
        {
            return new List<Line>
            {
                new Line(new PointF(MatrixPoints[0, 0], MatrixPoints[0, 1]), new PointF(MatrixPoints[1, 0], MatrixPoints[1, 1])),
                new Line(new PointF(MatrixPoints[1, 0], MatrixPoints[1, 1]), new PointF(MatrixPoints[2, 0], MatrixPoints[2, 1])),
                new Line(new PointF(MatrixPoints[2, 0], MatrixPoints[2, 1]), new PointF(MatrixPoints[3, 0], MatrixPoints[3, 1])),
                new Line(new PointF(MatrixPoints[3, 0], MatrixPoints[3, 1]), new PointF(MatrixPoints[0, 0], MatrixPoints[0, 1]))
            };

        }

        protected override void SetDefaultPoints()
        {
            var points = new List<PointF>
            {
                new PointF(50, 50),
                new PointF(50, -50),
                new PointF(-50, -50),
                new PointF(-50, 50)
            };
            MatrixPoints = new float[4, 3];

            for (int i = 0; i < points.Count; i++)
            {
                MatrixPoints[i, 0] = points[i].X;
                MatrixPoints[i, 1] = points[i].Y;
                MatrixPoints[i, 2] = 1;
            }
        }

        #endregion
    }
}
