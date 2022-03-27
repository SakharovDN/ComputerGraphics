namespace ComputerGraphics
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Timers;
    using System.Windows.Forms;

    using Figures;

    using Services;

    using Timer = System.Timers.Timer;

    public partial class ComputerGraphicsForm : Form
    {
        #region Fields

        protected Figure _figure;
        private readonly DrawingService _drawingService;
        private readonly Timer _timer;
        private int _prevX, _prevY;
        private Size _prevSize;

        #endregion

        #region Events

        private event EventHandler<Size> PictureBoxSizeChanged;

        #endregion

        #region Constructors

        public ComputerGraphicsForm()
        {
            InitializeComponent();
            var lineParameters = new LineParameters(thicknessTrackBar.Value, colorDialog.Color);
            _drawingService = new DrawingService(lineParameters, pictureBox.Size);
            var figures = new List<string>
            {
                nameof(Cube),
                nameof(Square),
                nameof(HexagonalPrism),
                nameof(Octahedron)
            };
            figureComboBox.DataSource = figures;
            _figure = new Cube();
            _timer = new Timer(1);
            PictureBoxSizeChanged += _drawingService.PictureBoxSizeChanged;
            _prevSize = pictureBox.Size;
        }

        #endregion

        #region Methods

        protected void Draw()
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
            _figure.RotateZ(1);
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
            float dSize = (float)Math.Sqrt((double)pictureBox.Size.Width * pictureBox.Size.Height / (_prevSize.Width * _prevSize.Height));
            _figure.Resize(dSize);
            _prevSize = pictureBox.Size;
            Draw();
        }

        private void figureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (figureComboBox.SelectedItem.ToString())
            {
                case "Octahedron":
                    _figure = new Octahedron();
                    break;

                case "Cube":
                    _figure = new Cube();
                    break;

                case "Square":
                    _figure = new Square();
                    break;

                case "HexagonalPrism":
                    _figure = new HexagonalPrism();
                    break;
            }

            _figure.SetPlanesVisibility(visiblePlanesCheckBox.Checked);
            Draw();
        }

        private void visiblePlanesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _figure.SetPlanesVisibility(visiblePlanesCheckBox.Checked);
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
