namespace LabWork4.Services
{
    using System;

    using Figures;

    using TransformationMatrices;

    public class ComputeService
    {
        #region Methods

        public float[,] Transform(Figure figure, ITransformationMatrix transformationMatrix)
        {
            return MultiplyMatrix(figure.MatrixPoints, transformationMatrix.Value);
        }

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
