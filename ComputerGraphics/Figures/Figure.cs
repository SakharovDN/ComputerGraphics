namespace ComputerGraphics.Figures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TransformationMatrices;

    public abstract class Figure
    {
        #region Fields

        private bool _invisiblePlanesIsVisible;

        #endregion

        #region Properties

        public List<Line> Lines => GetLines();

        public List<Plane> Planes => GetPlanes();

        public float[,] MatrixPoints { get; set; }

        #endregion

        #region Constructors

        protected Figure()
        {
            SetDefaultPoints();
            _invisiblePlanesIsVisible = false;
        }

        #endregion

        #region Methods

        public void RotateX(double degree)
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new XRotationMatrix(degree).Value);
        }

        public void RotateY(double degree)
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new YRotationMatrix(degree).Value);
        }

        public void RotateZ(double degree)
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new ZRotationMatrix(degree).Value);
        }

        public void MoveRight()
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new DisplacementMatrix(1, 0, 0).Value);
        }

        public void MoveLeft()
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new DisplacementMatrix(-1, 0, 0).Value);
        }

        public void MoveDown()
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new DisplacementMatrix(0, 1, 0).Value);
        }

        public void MoveUp()
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new DisplacementMatrix(0, -1, 0).Value);
        }

        public void Resize(float coeff)
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new ResizeMatrix(coeff).Value);
        }

        public void Refresh()
        {
            SetDefaultPoints();
        }

        public List<Line> GetLines()
        {
            return _invisiblePlanesIsVisible
                       ? Planes.Select(plane => plane.Lines).ToList()
                       : (from plane in Planes where plane.IsVisible() select plane.Lines).ToList();
        }

        public void SetPlanesVisibility(bool value)
        {
            _invisiblePlanesIsVisible = value;
        }

        protected float[] GetRow(int rowNumber)
        {
            return Enumerable.Range(0, MatrixPoints.GetLength(1)).Select(x => MatrixPoints[rowNumber, x]).ToArray();
        }

        protected abstract List<Plane> GetPlanes();
        protected abstract void SetDefaultPoints();

        private static float[,] MultiplyMatrix(float[,] matrixA, float[,] matrixB)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            float[,] matrixC = new float[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixC[i, j] = 0;

                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        #endregion
    }
}
