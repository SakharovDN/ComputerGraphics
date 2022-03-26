namespace LabWork6.Figures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TransformationMatrices;

    public abstract class Figure
    {
        #region Properties

        public List<Line> Lines => GetLines();

        public List<Plane> Planes => GetPlanes();

        public float[,] MatrixPoints { get; set; }

        #endregion

        #region Constructors

        protected Figure()
        {
            SetDefaultPoints();
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

        public List<Line> GetLines()
        {
            return (from plane in Planes where plane.IsVisible() select plane.Lines).ToList();
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
