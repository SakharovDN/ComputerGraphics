namespace LabWork5.Figures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using TransformationMatrices;

    public abstract class Figure
    {
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

        public void RotateZ()
        {
            MatrixPoints = MultiplyMatrix(MatrixPoints, new ZRotationMatrix(1).Value);
        }

        public void Refresh()
        {
            SetDefaultPoints();
        }

        protected PointF RowToPoint(int rowNumber)
        {
            return new PointF(MatrixPoints[rowNumber, 0], MatrixPoints[rowNumber, 1]);
        }

        protected abstract List<Line> GetLines();
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
