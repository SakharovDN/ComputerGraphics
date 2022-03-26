namespace LabWork4.Figures
{
    using System;
    using System.Collections.Generic;

    using Services;

    using TransformationMatrices;

    public abstract class Figure
    {
        #region Fields

        protected readonly ComputeService _computeService;

        #endregion

        #region Properties

        public List<Line> Lines => GetLines();

        public float[,] MatrixPoints { get; set; }

        #endregion

        #region Constructors

        protected Figure()
        {
            SetDefaultPoints();

            if (Lines.Count < 1)
            {
                throw new Exception("Фигура не задана");
            }

            _computeService = new ComputeService();
        }

        #endregion

        #region Methods

        public void MoveLeft()
        {
            MatrixPoints = _computeService.Transform(this, new DisplacementMatrix(-1, 0));
        }

        public void MoveRight()
        {
            MatrixPoints = _computeService.Transform(this, new DisplacementMatrix(1, 0));
        }

        public void MoveUp()
        {
            MatrixPoints = _computeService.Transform(this, new DisplacementMatrix(0, 1));
        }

        public void MoveDown()
        {
            MatrixPoints = _computeService.Transform(this, new DisplacementMatrix(0, -1));
        }

        public void RotateUndo()
        {
            MatrixPoints = _computeService.Transform(this, new RotationMatrix(-1));
        }

        public void RotateRedo()
        {
            MatrixPoints = _computeService.Transform(this, new RotationMatrix(1));
        }

        public void Increase()
        {
            MatrixPoints = _computeService.Transform(this, new ScalingMatrix((float)1.05));
        }

        public void Decrease()
        {
            MatrixPoints = _computeService.Transform(this, new ScalingMatrix((float)(1 / 1.05)));
        }

        public void Refresh()
        {
            SetDefaultPoints();
        }

        protected abstract List<Line> GetLines();
        protected abstract void SetDefaultPoints();

        #endregion
    }
}
