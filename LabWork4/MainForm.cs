namespace LabWork4
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

        #endregion

        #region Events

        private event EventHandler<Size> PictureBoxSizeChanged;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            _figure = new Square();
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

        private void MoveRight(object sender, ElapsedEventArgs e)
        {
            _figure.MoveRight();
            Draw();
        }

        private void MoveLeft(object sender, ElapsedEventArgs e)
        {
            _figure.MoveLeft();
            Draw();
        }

        private void MoveUp(object sender, ElapsedEventArgs e)
        {
            _figure.MoveUp();
            Draw();
        }

        private void MoveDown(object sender, ElapsedEventArgs e)
        {
            _figure.MoveDown();
            Draw();
        }

        private void RotateRedo(object sender, ElapsedEventArgs e)
        {
            _figure.RotateRedo();
            Draw();
        }

        private void RotateUndo(object sender, ElapsedEventArgs e)
        {
            _figure.RotateUndo();
            Draw();
        }

        private void Decrease(object sender, ElapsedEventArgs e)
        {
            _figure.Decrease();
            Draw();
        }

        private void Increase(object sender, ElapsedEventArgs e)
        {
            _figure.Increase();
            Draw();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void moveButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                if (button == moveRightButton)
                {
                    _timer.Elapsed += MoveRight;
                }
                else if (button == moveLeftButton)
                {
                    _timer.Elapsed += MoveLeft;
                }
                else if (button == moveDownButton)
                {
                    _timer.Elapsed += MoveDown;
                }
                else if (button == moveUpButton)
                {
                    _timer.Elapsed += MoveUp;
                }
                else if (button == rotateRedoButton)
                {
                    _timer.Elapsed += RotateRedo;
                }
                else if (button == rotateUndoButton)
                {
                    _timer.Elapsed += RotateUndo;
                }
                else if (button == increaseButton)
                {
                    _timer.Elapsed += Increase;
                }
                else if (button == decreaseButton)
                {
                    _timer.Elapsed += Decrease;
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

            if (button == moveRightButton)
            {
                _timer.Elapsed -= MoveRight;
            }
            else if (button == moveLeftButton)
            {
                _timer.Elapsed -= MoveLeft;
            }
            else if (button == moveDownButton)
            {
                _timer.Elapsed -= MoveDown;
            }
            else if (button == moveUpButton)
            {
                _timer.Elapsed -= MoveUp;
            }
            else if (button == rotateRedoButton)
            {
                _timer.Elapsed -= RotateRedo;
            }
            else if (button == rotateUndoButton)
            {
                _timer.Elapsed -= RotateUndo;
            }
            else if (button == increaseButton)
            {
                _timer.Elapsed -= Increase;
            }
            else if (button == decreaseButton)
            {
                _timer.Elapsed -= Decrease;
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _drawingService.LineParameters.Color = colorDialog.Color;
                Draw();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            _figure.Refresh();
            Draw();
        }

        private void thicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            _drawingService.LineParameters.Thickness = thicknessTrackBar.Value;
            Draw();
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            PictureBoxSizeChanged?.Invoke(null, pictureBox.Size);
            Draw();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'A':
                case 'a':
                    MoveLeft(null, null);
                    break;

                case 'D':
                case 'd':
                    MoveRight(null, null);
                    break;

                case 'S':
                case 's':
                    MoveDown(null, null);
                    break;

                case 'W':
                case 'w':
                    MoveUp(null, null);
                    break;

                case 'Q':
                case 'q':
                    RotateUndo(null, null);
                    break;

                case 'E':
                case 'e':
                    RotateRedo(null, null);
                    break;

                case 'R':
                case 'r':
                    Increase(null, null);
                    break;

                case 'F':
                case 'f':
                    Decrease(null, null);
                    break;
            }
        }

        #endregion
    }
}
