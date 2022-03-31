namespace ComputerGraphics.Figures
{
    using System;
    using System.Collections.Generic;

    public class Function : Figure
    {
        #region Methods

        protected override List<Plane> GetPlanes()
        {
            var planes = new List<Plane>();
            var points = new List<float[]>();

            for (int i = 0; i < MatrixPoints.GetLength(0); i++)
            {
                //if (i % 61 == 0 && i != 0)
                //{
                //    planes.Add(new Plane()
                //    {
                //        Points = points
                //    });
                //    points = new List<float[]>()
                //    {
                //        GetRow(i)
                //    };
                //}
                points.Add(GetRow(i));
            }

            for (int i = 0; i < 61; i++)
            {
                points = new List<float[]>();

                for (int j = i; j < MatrixPoints.GetLength(0); j += 61)
                {
                    points.Add(GetRow(j));
                }

                planes.Add(
                    new Plane
                    {
                        Points = points
                    });
            }

            return planes;
        }

        protected override void SetDefaultPoints()
        {
            MatrixPoints = new float[1681, 4];
            int counter = 0;

            for (double u = 0; u <= 2*Math.PI; u += Math.PI*0.05)
            {
                for (double v = -Math.PI; v <= Math.PI; v += Math.PI * 0.05)
                {
                    MatrixPoints[counter, 0] = (float)((10 + 5*Math.Cos(v)) * Math.Cos(u));
                    MatrixPoints[counter, 1] = (float)((10 + 5 * Math.Cos(v)) * Math.Sin(u));
                    MatrixPoints[counter, 2] = (float)(5 * Math.Sin(v));
                    //MatrixPoints[counter, 0] = (float)((10 + Math.Cos(u / 2) * Math.Sin(v) - Math.Sin(u / 2) * Math.Sin(2 * v)) * Math.Cos(u));
                    //MatrixPoints[counter, 1] = (float)((10 + Math.Cos(u / 2) * Math.Sin(v) - Math.Sin(u / 2) * Math.Sin(2 * v)) * Math.Sin(u));
                    //MatrixPoints[counter, 2] = (float)(Math.Sin(u / 2) * Math.Sin(v) + Math.Cos(u / 2) * Math.Sin(2 * v));
                    MatrixPoints[counter, 3] = 1;
                    counter++;
                }
            }
        }

        #endregion
    }
}
