namespace ComputerGraphics.Figures
{
    using System.Collections.Generic;

    public class Cube : Figure
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
                        GetRow(0)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(3),
                        GetRow(0),
                        GetRow(4),
                        GetRow(7),
                        GetRow(3)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(2),
                        GetRow(3),
                        GetRow(7),
                        GetRow(6),
                        GetRow(2)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(1),
                        GetRow(2),
                        GetRow(6),
                        GetRow(5),
                        GetRow(1)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(0),
                        GetRow(1),
                        GetRow(5),
                        GetRow(4),
                        GetRow(0)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(4),
                        GetRow(5),
                        GetRow(6),
                        GetRow(7),
                        GetRow(4)
                    }
                }
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

        #endregion
    }
}
