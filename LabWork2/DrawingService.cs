namespace LabWork2
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    public class DrawingService
    {
        #region Fields

        private readonly Graphics _graphics;
        private readonly Bitmap _bitmap;
        private readonly Pen _pen;
        private Point _pointA;
        private Point _pointB;

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

        public Bitmap Draw()
        {
            switch (LineParameters.DrawingAlgorithm)
            {
                case DrawingAlgorithm.DDA:
                    DrawDda();
                    break;

                case DrawingAlgorithm.AsymmetricalDDA:
                    DrawAsymmDda();
                    break;

                case DrawingAlgorithm.Filling:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            return _bitmap;
        }

        private void DrawAsymmDda()
        {
            throw new NotImplementedException();
        }

        private void DrawDda()
        {
            int dx = _pointB.X - _pointA.X;
            int dy = _pointB.Y - _pointA.Y;
            int xt = _pointA.X;
            int yt = _pointA.Y;
            int n = 100;
            for (int i = 0; i < n; i++)
            {
                _graphics.DrawRectangle(_pen, xt,yt,2,2);
                xt += dx / n;
                yt += dy / n;
            }
        }

        public void CleanBitmap(Size size)
        {
            _graphics.Clear(Color.White);
        }

        public void SetPointA(int x, int y)
        {
            _pointA = new Point(x, y);
        }

        public void SetPointB(int x, int y)
        {
            _pointB = new Point(x, y);
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
