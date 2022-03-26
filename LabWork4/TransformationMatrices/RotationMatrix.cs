namespace LabWork4.TransformationMatrices
{
    using System;

    public class RotationMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public RotationMatrix(double degree)
        {
            Value = new float[3, 3];
            Value[0, 0] = (float)Math.Cos(Math.PI * degree / 180);
            Value[0, 1] = (float)Math.Sin(Math.PI * degree / 180);
            Value[0, 2] = 0;
            Value[1, 0] = (float)-Math.Sin(Math.PI * degree / 180);
            Value[1, 1] = (float)Math.Cos(Math.PI * degree / 180);
            Value[1, 2] = 0;
            Value[2, 0] = 0;
            Value[2, 1] = 0;
            Value[2, 2] = 1;
        }

        #endregion
    }
}
