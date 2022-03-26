namespace LabWork6
{
    using System;
    using System.Drawing;
    using System.Timers;
    using System.Windows.Forms;

    using Figures;

    using Services;

    using Timer = System.Timers.Timer;

    public partial class MainForm : Form
    {
        #region Fields

        private readonly Figure _figure;
        private readonly DrawingService _drawingService;
        private readonly Timer _timer;
        private int _prevX, _prevY;

        #endregion

        #region Events

        private event EventHandler<Size> PictureBoxSizeChanged;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            _figure = new HexagonalPrism();
            var lineParameters = new LineParameters(thicknessTrackBar.Value, colorDialog.Color);
            _drawingService = new DrawingService(lineParameters, pictureBox.Size);
            _timer = new Timer(1);
            PictureBoxSizeChanged += _drawingService.PictureBoxSizeChanged;
        }

        #endregion

        #region Methods

        private void Draw()
        {
            pictureBox.Image = _drawingService.Draw(_figure);
        }

        private void RotateX(object sender, ElapsedEventArgs e)
        {
            _figure.RotateX(1);
            Draw();
        }

        private void RotateY(object sender, ElapsedEventArgs e)
        {
            _figure.RotateY(1);
            Draw();
        }

        private void RotateZ(object sender, ElapsedEventArgs e)
        {
            _figure.RotateZ();
            Draw();
        }

        private void moveButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                if (button == xRotateButton)
                {
                    _timer.Elapsed += RotateX;
                }
                else if (button == yRotateButton)
                {
                    _timer.Elapsed += RotateY;
                }
                else if (button == zRotateButton)
                {
                    _timer.Elapsed += RotateZ;
                }
            }

            _timer.Start();
        }

        private void moveButton_MouseUp(object sender, MouseEventArgs e)
        {
            _timer.Stop();

            if (!(sender is Button button))
            {
                return;
            }

            if (button == xRotateButton)
            {
                _timer.Elapsed -= RotateX;
            }
            else if (button == yRotateButton)
            {
                _timer.Elapsed -= RotateY;
            }
            else if (button == zRotateButton)
            {
                _timer.Elapsed -= RotateZ;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _drawingService.LineParameters.Color = colorDialog.Color;
                Draw();
            }
        }

        private void thicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            _drawingService.LineParameters.Thickness = thicknessTrackBar.Value;
            Draw();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            _figure.Refresh();
            Draw();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            PictureBoxSizeChanged?.Invoke(null, pictureBox.Size);
            Draw();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            if (_prevY < e.Y)
            {
                _figure.RotateX(1);
            }
            else if (_prevY > e.Y)
            {
                _figure.RotateX(-1);
            }

            if (_prevX < e.X)
            {
                _figure.RotateY(-1);
            }
            else if (_prevX > e.X)
            {
                _figure.RotateY(1);
            }

            _prevX = e.X;
            _prevY = e.Y;
            Draw();
        }

        #endregion
    }
}
