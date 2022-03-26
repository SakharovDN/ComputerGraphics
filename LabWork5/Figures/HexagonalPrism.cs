namespace LabWork5.Figures
{
    using System.Collections.Generic;

    public class HexagonalPrism : Figure
    {
        #region Methods

        protected override List<Line> GetLines()
        {
            return new List<Line>
            {
                new Line(
                    RowToPoint(0),
                    RowToPoint(1)),
                new Line(
                    RowToPoint(1),
                    RowToPoint(2)),
                new Line(
                    RowToPoint(2),
                    RowToPoint(3)),
                new Line(
                    RowToPoint(3),
                    RowToPoint(4)),
                new Line(
                    RowToPoint(4),
                    RowToPoint(5)),
                new Line(
                    RowToPoint(5),
                    RowToPoint(0)),
                new Line(
                    RowToPoint(6),
                    RowToPoint(7)),
                new Line(
                    RowToPoint(7),
                    RowToPoint(8)),
                new Line(
                    RowToPoint(8),
                    RowToPoint(9)),
                new Line(
                    RowToPoint(9),
                    RowToPoint(10)),
                new Line(
                    RowToPoint(10),
                    RowToPoint(11)),
                new Line(
                    RowToPoint(11),
                    RowToPoint(6)),
                new Line(
                    RowToPoint(0),
                    RowToPoint(6)),
                new Line(
                    RowToPoint(1),
                    RowToPoint(7)),
                new Line(
                    RowToPoint(2),
                    RowToPoint(8)),
                new Line(
                    RowToPoint(3),
                    RowToPoint(9)),
                new Line(
                    RowToPoint(4),
                    RowToPoint(10)),
                new Line(
                    RowToPoint(5),
                    RowToPoint(11))
            };
        }

        protected override void SetDefaultPoints()
        {
            MatrixPoints = new float[12, 4];
            MatrixPoints[0, 0] = 30;
            MatrixPoints[0, 1] = 100;
            MatrixPoints[0, 2] = 52;
            MatrixPoints[0, 3] = 1;
            MatrixPoints[1, 0] = 60;
            MatrixPoints[1, 1] = 100;
            MatrixPoints[1, 2] = 0;
            MatrixPoints[1, 3] = 1;
            MatrixPoints[2, 0] = 30;
            MatrixPoints[2, 1] = 100;
            MatrixPoints[2, 2] = -52;
            MatrixPoints[2, 3] = 1;
            MatrixPoints[3, 0] = -30;
            MatrixPoints[3, 1] = 100;
            MatrixPoints[3, 2] = -52;
            MatrixPoints[3, 3] = 1;
            MatrixPoints[4, 0] = -60;
            MatrixPoints[4, 1] = 100;
            MatrixPoints[4, 2] = 0;
            MatrixPoints[4, 3] = 1;
            MatrixPoints[5, 0] = -30;
            MatrixPoints[5, 1] = 100;
            MatrixPoints[5, 2] = 52;
            MatrixPoints[5, 3] = 1;
            MatrixPoints[6, 0] = 30;
            MatrixPoints[6, 1] = -100;
            MatrixPoints[6, 2] = 52;
            MatrixPoints[6, 3] = 1;
            MatrixPoints[7, 0] = 60;
            MatrixPoints[7, 1] = -100;
            MatrixPoints[7, 2] = 0;
            MatrixPoints[7, 3] = 1;
            MatrixPoints[8, 0] = 30;
            MatrixPoints[8, 1] = -100;
            MatrixPoints[8, 2] = -52;
            MatrixPoints[8, 3] = 1;
            MatrixPoints[9, 0] = -30;
            MatrixPoints[9, 1] = -100;
            MatrixPoints[9, 2] = -52;
            MatrixPoints[9, 3] = 1;
            MatrixPoints[10, 0] = -60;
            MatrixPoints[10, 1] = -100;
            MatrixPoints[10, 2] = 0;
            MatrixPoints[10, 3] = 1;
            MatrixPoints[11, 0] = -30;
            MatrixPoints[11, 1] = -100;
            MatrixPoints[11, 2] = 52;
            MatrixPoints[11, 3] = 1;
        }

        #endregion
    }
}
