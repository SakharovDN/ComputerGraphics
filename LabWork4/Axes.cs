namespace LabWork4
{
    using System.Collections.Generic;
    using System.Drawing;

    public class Axes
    {
        #region Properties

        public List<Line> Lines { get; set; }

        #endregion

        #region Constructors

        public Axes(Size size)
        {
            Lines = new List<Line>
            {
                new Line(
                    new List<PointF>
                    {
                        new PointF(-size.Width, size.Height / 2),
                        new PointF(size.Width, size.Height / 2)
                    }),
                new Line(
                    new List<PointF>
                    {
                        new PointF(size.Width / 2, size.Height),
                        new PointF(size.Width / 2, -size.Height)
                    })
            };
        }

        #endregion
    }
}
