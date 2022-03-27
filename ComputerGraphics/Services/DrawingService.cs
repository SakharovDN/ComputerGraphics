namespace ComputerGraphics.Services
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;

    using Figures;

    public class DrawingService
    {
        #region Fields

        private Graphics _graphics;
        private Bitmap _bitmap;
        private readonly Pen _pen;

        #endregion

        #region Properties

        public LineParameters LineParameters { get; set; }

        #endregion

        #region Constructors

        public DrawingService(LineParameters lineParameters, Size size)
        {
            LineParameters = lineParameters;
            LineParameters.PropertyChanged += HandleLineParametersChanged;
            _bitmap = new Bitmap(size.Width, size.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _pen = new Pen(LineParameters.Color, LineParameters.Thickness);
        }

        #endregion

        #region Methods

        public Bitmap Draw(Figure figure)
        {
            CleanBitmap();
            DrawLines(figure);
            return _bitmap;
        }

        public void PictureBoxSizeChanged(object sender, Size size)
        {
            _bitmap = new Bitmap(size.Width, size.Height);
            _graphics = Graphics.FromImage(_bitmap);
        }

        private void DrawLines(Figure figure)
        {
            List<Line> lines = figure.Lines
                                     .Select(
                                          line => line.Points.Select(
                                                           figurePoint => new PointF(
                                                               figurePoint.X + _bitmap.Width / 2,
                                                               figurePoint.Y + _bitmap.Height / 2))
                                                      .ToList()).Select(points => new Line(points)).ToList();

            foreach (Line line in lines)
            {
                _graphics.DrawLines(_pen, line.Points.ToArray());
            }
        }

        private void CleanBitmap()
        {
            _graphics.Clear(Color.White);
        }

        private void HandleLineParametersChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(LineParameters.Color):
                    _pen.Color = LineParameters.Color;
                    break;

                case nameof(LineParameters.Thickness):
                    _pen.Width = LineParameters.Thickness;
                    break;
            }
        }

        #endregion
    }
}
