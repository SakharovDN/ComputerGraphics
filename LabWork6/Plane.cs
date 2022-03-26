namespace LabWork6
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class Plane
    {
        #region Fields

        public List<float[]> Points;

        #endregion

        #region Properties

        public Line Lines => GetLine();

        private float[] Coefficients => GetCoefficients(Points[0], Points[1], Points[2]);

        #endregion

        #region Methods

        public bool IsVisible()
        {
            double acos = Math.Acos(
                Coefficients[2] / Math.Sqrt(Math.Pow(Coefficients[0], 2) + Math.Pow(Coefficients[1], 2) + Math.Pow(Coefficients[2], 2)));
            return acos < Math.PI / 2;
        }

        private Line GetLine()
        {
            List<PointF> points = Points.Select(point => new PointF(point[0], point[1])).ToList();
            return new Line(points);
        }

        private static float[] GetCoefficients(float[] x, float[] y, float[] z)
        {
            float[] coefficients = new float[3];
            float tmp = -x[0] * ((x[1] - y[1]) * (y[2] - z[2]) - (x[2] - y[2]) * (y[1] - z[1]))
                        + x[1] * ((x[0] - y[0]) * (y[2] - z[2]) - (x[2] - y[2]) * (y[0] - z[0]))
                        - x[2] * ((x[0] - y[0]) * (y[1] - z[1]) - (x[1] - y[1]) * (y[0] - z[0]));
            coefficients[0] = ((x[1] - y[1]) * (y[2] - z[2]) - (x[2] - y[2]) * (y[1] - z[1])) / tmp;
            coefficients[1] = -((x[0] - y[0]) * (y[2] - z[2]) - (x[2] - y[2]) * (y[0] - z[0])) / tmp;
            coefficients[2] = ((x[0] - y[0]) * (y[1] - z[1]) - (x[1] - y[1]) * (y[0] - z[0])) / tmp;
            return coefficients;
        }

        #endregion
    }
}
