namespace ComputerGraphics.Figures
{
    using System.Collections.Generic;

    public class HexagonalPrism : Figure
    {
        #region Methods

        protected override List<Plane> GetPlanes()
        {
            return new List<Plane>
            {
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(0),
                        GetRow(1),
                        GetRow(2),
                        GetRow(3),
                        GetRow(4),
                        GetRow(5),
                        GetRow(0)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(6),
                        GetRow(7),
                        GetRow(8),
                        GetRow(9),
                        GetRow(10),
                        GetRow(11),
                        GetRow(6)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(1),
                        GetRow(2),
                        GetRow(8),
                        GetRow(7),
                        GetRow(1)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(2),
                        GetRow(3),
                        GetRow(9),
                        GetRow(8),
                        GetRow(2)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(3),
                        GetRow(4),
                        GetRow(10),
                        GetRow(9),
                        GetRow(3)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(4),
                        GetRow(5),
                        GetRow(11),
                        GetRow(10),
                        GetRow(4)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(5),
                        GetRow(0),
                        GetRow(6),
                        GetRow(11),
                        GetRow(5)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(0),
                        GetRow(1),
                        GetRow(7),
                        GetRow(6),
                        GetRow(0)
                    }
                }
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
