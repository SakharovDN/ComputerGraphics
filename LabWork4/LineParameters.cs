namespace LabWork4
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    using Annotations;

    public class LineParameters : INotifyPropertyChanged
    {
        #region Fields

        private int _thickness;

        private Color _color;

        #endregion

        #region Properties

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

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructors

        public LineParameters(int thickness, Color color)
        {
            Thickness = thickness;
            Color = color;
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
