using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public partial class MainForm : Form
    {
        private DrawingService _drawingService;
        public MainForm()
        {
            InitializeComponent();
            drawingAlgorithmComboBox.DataSource = Enum.GetValues(typeof(DrawingAlgorithm));
            lineTypeComboBox.DataSource = Enum.GetValues(typeof(LineType));
            var lineParameters = new LineParameters(
                (DrawingAlgorithm)drawingAlgorithmComboBox.SelectedItem,
                thicknessTrackBar.Value,
                colorDialog.Color,
                (LineType)lineTypeComboBox.SelectedItem);
            _drawingService = new DrawingService(lineParameters, pictureBox.Size);
        }

        private void drawByCoordinatesButton_Click(object sender, EventArgs e)
        {
            _drawingService.SetPointA((int)x1NumericUpDown.Value, (int)y1NumericUpDown.Value);
            _drawingService.SetPointB((int)x2NumericUpDown.Value, (int)y2NumericUpDown.Value);
            pictureBox.Image = _drawingService.Draw();
        }

        #region Handling parameter changes

        private void drawingAlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_drawingService != null)
            {
                _drawingService.LineParameters.DrawingAlgorithm = (DrawingAlgorithm)drawingAlgorithmComboBox.SelectedItem;
            }
        }

        private void thicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            if (_drawingService != null)
            {
                _drawingService.LineParameters.Thickness = thicknessTrackBar.Value;
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (_drawingService == null)
            {
                return;
            }

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _drawingService.LineParameters.Color = colorDialog.Color;
            }
        }

        private void lineTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_drawingService != null)
            {
                _drawingService.LineParameters.Type = (LineType)lineTypeComboBox.SelectedItem;
            }
        }

        #endregion

        private void refreshButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            _drawingService.CleanBitmap(pictureBox.Size);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _drawingService.SetPointA(e.X, e.Y);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _drawingService.SetPointB(e.X, e.Y);
            pictureBox.Image = _drawingService.Draw();
        }
    }
}
