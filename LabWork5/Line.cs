namespace LabWork5
{
    using System.Collections.Generic;
    using System.Drawing;

    public class Line
    {
        #region Properties

        public List<PointF> Points { get; set; }

        #endregion

        #region Constructors

        public Line(List<PointF> points)
        {
            Points = points;
        }

        public Line(PointF pointA, PointF pointB)
        {
            Points = new List<PointF>
            {
                pointA,
                pointB
            };
        }

        #endregion
    }
}
