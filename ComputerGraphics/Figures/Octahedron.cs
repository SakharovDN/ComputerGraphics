namespace ComputerGraphics.Figures
{
    using System.Collections.Generic;

    public class Octahedron : Figure
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
                        GetRow(0)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(0),
                        GetRow(2),
                        GetRow(3),
                        GetRow(0)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(0),
                        GetRow(3),
                        GetRow(4),
                        GetRow(0)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(0),
                        GetRow(4),
                        GetRow(1),
                        GetRow(0)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(5),
                        GetRow(1),
                        GetRow(2),
                        GetRow(5)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(5),
                        GetRow(2),
                        GetRow(3),
                        GetRow(5)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(5),
                        GetRow(3),
                        GetRow(4),
                        GetRow(5)
                    }
                },
                new Plane
                {
                    Points = new List<float[]>
                    {
                        GetRow(5),
                        GetRow(4),
                        GetRow(1),
                        GetRow(5)
                    }
                }
            };
        }

        protected override void SetDefaultPoints()
        {
            MatrixPoints = new float[6, 4];
            MatrixPoints[0, 0] = 0;
            MatrixPoints[0, 1] = 150;
            MatrixPoints[0, 2] = 0;
            MatrixPoints[0, 3] = 1;
            MatrixPoints[1, 0] = 100;
            MatrixPoints[1, 1] = 0;
            MatrixPoints[1, 2] = 100;
            MatrixPoints[1, 3] = 1;
            MatrixPoints[2, 0] = 100;
            MatrixPoints[2, 1] = 0;
            MatrixPoints[2, 2] = -100;
            MatrixPoints[2, 3] = 1;
            MatrixPoints[3, 0] = -100;
            MatrixPoints[3, 1] = 0;
            MatrixPoints[3, 2] = -100;
            MatrixPoints[3, 3] = 1;
            MatrixPoints[4, 0] = -100;
            MatrixPoints[4, 1] = 0;
            MatrixPoints[4, 2] = 100;
            MatrixPoints[4, 3] = 1;
            MatrixPoints[5, 0] = 0;
            MatrixPoints[5, 1] = -150;
            MatrixPoints[5, 2] = 0;
            MatrixPoints[5, 3] = 1;
        }

        #endregion
    }
}
