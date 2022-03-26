namespace LabWork6.TransformationMatrices
{
    using System;

    public class XRotationMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public XRotationMatrix(double degree)
        {
            Value = new float[4, 4];
            Value[0, 0] = 1;
            Value[0, 1] = 0;
            Value[0, 2] = 0;
            Value[0, 3] = 0;
            Value[1, 0] = 0;
            Value[1, 1] = (float)Math.Cos(degree * Math.PI / 180);
            Value[1, 2] = (float)Math.Sin(degree * Math.PI / 180);
            Value[1, 3] = 0;
            Value[2, 0] = 0;
            Value[2, 1] = (float)-Math.Sin(degree * Math.PI / 180);
            Value[2, 2] = (float)Math.Cos(degree * Math.PI / 180);
            Value[2, 3] = 0;
            Value[3, 0] = 0;
            Value[3, 1] = 0;
            Value[3, 2] = 0;
            Value[3, 3] = 1;
        }

        #endregion
    }

    public class YRotationMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public YRotationMatrix(double degree)
        {
            Value = new float[4, 4];
            Value[0, 0] = (float)Math.Cos(degree * Math.PI / 180);
            Value[0, 1] = 0;
            Value[0, 2] = (float)-Math.Sin(degree * Math.PI / 180);
            Value[0, 3] = 0;
            Value[1, 0] = 0;
            Value[1, 1] = 1;
            Value[1, 2] = 0;
            Value[1, 3] = 0;
            Value[2, 0] = (float)Math.Sin(degree * Math.PI / 180);
            Value[2, 1] = 0;
            Value[2, 2] = (float)Math.Cos(degree * Math.PI / 180);
            Value[2, 3] = 0;
            Value[3, 0] = 0;
            Value[3, 1] = 0;
            Value[3, 2] = 0;
            Value[3, 3] = 1;
        }

        #endregion
    }

    public class ZRotationMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public ZRotationMatrix(double degree)
        {
            Value = new float[4, 4];
            Value[0, 0] = (float)Math.Cos(degree * Math.PI / 180);
            Value[0, 1] = (float)Math.Sin(degree * Math.PI / 180);
            Value[0, 2] = 0;
            Value[0, 3] = 0;
            Value[1, 0] = (float)-Math.Sin(degree * Math.PI / 180);
            Value[1, 1] = (float)Math.Cos(degree * Math.PI / 180);
            Value[1, 2] = 0;
            Value[1, 3] = 0;
            Value[2, 0] = 0;
            Value[2, 1] = 0;
            Value[2, 2] = 1;
            Value[2, 3] = 0;
            Value[3, 0] = 0;
            Value[3, 1] = 0;
            Value[3, 2] = 0;
            Value[3, 3] = 1;
        }

        #endregion
    }
}
