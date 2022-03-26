namespace LabWork2
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    using Annotations;

    public class LineParameters : INotifyPropertyChanged
    {
        #region Fields

        private DrawingAlgorithm _drawingAlgorithm;
        private int _thickness;

        private Color _color;

        private LineType _type;

        #endregion

        #region Properties

        public DrawingAlgorithm DrawingAlgorithm
        {
            get => _drawingAlgorithm;
            set
            {
                _drawingAlgorithm = value;
                OnPropertyChanged();
            }
        }

        public int Thickness
        {
            get => _thickness;
            set
            {
                _thickness = value;
                OnPropertyChanged();
            }
        }

        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }

        public LineType Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructors

        public LineParameters(DrawingAlgorithm drawingAlgorithm, int thickness, Color color, LineType type)
        {
            DrawingAlgorithm = drawingAlgorithm;
            Thickness = thickness;
            Color = color;
            Type = type;
        }

        #endregion

        #region Methods

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
