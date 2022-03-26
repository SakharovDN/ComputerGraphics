namespace LabWork4.TransformationMatrices
{
    public class ScalingMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public ScalingMatrix(float coeff)
        {
            Value = new float[3, 3];
            Value[0, 0] = coeff;
            Value[0, 1] = 0;
            Value[0, 2] = 0;
            Value[1, 0] = 0;
            Value[1, 1] = coeff;
            Value[1, 2] = 0;
            Value[2, 0] = 0;
            Value[2, 1] = 0;
            Value[2, 2] = 1;
        }

        #endregion
    }
}
