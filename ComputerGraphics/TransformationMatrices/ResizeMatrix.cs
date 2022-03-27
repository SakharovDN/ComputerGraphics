namespace ComputerGraphics.TransformationMatrices
{
    public class ResizeMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public ResizeMatrix(float coeff)
        {
            Value = new float[4, 4];
            Value[0, 0] = coeff;
            Value[0, 1] = 0;
            Value[0, 2] = 0;
            Value[0, 3] = 0;
            Value[1, 0] = 0;
            Value[1, 1] = coeff;
            Value[1, 2] = 0;
            Value[1, 3] = 0;
            Value[2, 0] = 0;
            Value[2, 1] = 0;
            Value[2, 2] = coeff;
            Value[2, 3] = 0;
            Value[3, 0] = 0;
            Value[3, 1] = 0;
            Value[3, 2] = 0;
            Value[3, 3] = 1;
        }

        #endregion
    }
}
