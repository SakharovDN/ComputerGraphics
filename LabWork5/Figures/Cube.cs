using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5.Figures
{
    public class Cube : Figure
    {
        protected override List<Line> GetLines()
        {
            return new List<Line>
            {
                new Line(RowToPoint(0), RowToPoint(1)),
                new Line(RowToPoint(1), RowToPoint(2)),
                new Line(RowToPoint(2), RowToPoint(3)),
                new Line(RowToPoint(3), RowToPoint(0)),
                new Line(RowToPoint(4), RowToPoint(5)),
                new Line(RowToPoint(5), RowToPoint(6)),
                new Line(RowToPoint(6), RowToPoint(7)),
                new Line(RowToPoint(7), RowToPoint(4)),
                new Line(RowToPoint(0), RowToPoint(4)),
                new Line(RowToPoint(1), RowToPoint(5)),
                new Line(RowToPoint(2), RowToPoint(6)),
                new Line(RowToPoint(3), RowToPoint(7)),
            };
        }

        protected override void SetDefaultPoints()
        {
            MatrixPoints = new float[8, 4];
            MatrixPoints[0, 0] = 100;
            MatrixPoints[0, 1] = 100;
            MatrixPoints[0, 2] = 100;
            MatrixPoints[0, 3] = 1;
            MatrixPoints[1, 0] = -100;
            MatrixPoints[1, 1] = 100;
            MatrixPoints[1, 2] = 100;
            MatrixPoints[1, 3] = 1;
            MatrixPoints[2, 0] = -100;
            MatrixPoints[2, 1] = -100;
            MatrixPoints[2, 2] = 100;
            MatrixPoints[2, 3] = 1;
            MatrixPoints[3, 0] = 100;
            MatrixPoints[3, 1] = -100;
            MatrixPoints[3, 2] = 100;
            MatrixPoints[3, 3] = 1;
            MatrixPoints[4, 0] = 100;
            MatrixPoints[4, 1] = 100;
            MatrixPoints[4, 2] = -100;
            MatrixPoints[4, 3] = 1;
            MatrixPoints[5, 0] = -100;
            MatrixPoints[5, 1] = 100;
            MatrixPoints[5, 2] = -100;
            MatrixPoints[5, 3] = 1;
            MatrixPoints[6, 0] = -100;
            MatrixPoints[6, 1] = -100;
            MatrixPoints[6, 2] = -100;
            MatrixPoints[6, 3] = 1;
            MatrixPoints[7, 0] = 100;
            MatrixPoints[7, 1] = -100;
            MatrixPoints[7, 2] = -100;
            MatrixPoints[7, 3] = 1;
        }
    }
}
