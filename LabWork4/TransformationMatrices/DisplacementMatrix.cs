namespace LabWork4.TransformationMatrices
{
    public class DisplacementMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public DisplacementMatrix(int k, int l)
        {
            Value = new float[3, 3];
            Value[0, 0] = 1;
            Value[0, 1] = 0;
            Value[0, 2] = 0;
            Value[1, 0] = 0;
            Value[1, 1] = 1;
            Value[1, 2] = 0;
            Value[2, 0] = k;
            Value[2, 1] = l;
            Value[2, 2] = 1;
        }

        #endregion
    }
}
