namespace ComputerGraphics.Figures
{
    using System.Collections.Generic;

    public class Square : Figure
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
                }
            };
        }

        protected override void SetDefaultPoints()
        {
            MatrixPoints = new float[8, 4];
            MatrixPoints[0, 0] = 100;
            MatrixPoints[0, 1] = 100;
            MatrixPoints[0, 2] = 0;
            MatrixPoints[0, 3] = 1;
            MatrixPoints[1, 0] = -100;
            MatrixPoints[1, 1] = 100;
            MatrixPoints[1, 2] = 0;
            MatrixPoints[1, 3] = 1;
            MatrixPoints[2, 0] = -100;
            MatrixPoints[2, 1] = -100;
            MatrixPoints[2, 2] = 0;
            MatrixPoints[2, 3] = 1;
            MatrixPoints[3, 0] = 100;
            MatrixPoints[3, 1] = -100;
            MatrixPoints[3, 2] = 0;
            MatrixPoints[3, 3] = 1;
        }

        #endregion
    }
}
