namespace LabWork5.TransformationMatrices
{
    public class DisplacementMatrix : ITransformationMatrix
    {
        #region Properties

        public float[,] Value { get; }

        #endregion

        #region Constructors

        public DisplacementMatrix(int l, int m, int n)
        {
            Value = new float[4, 4];
            Value[0, 0] = 1;
            Value[0, 1] = 0;
            Value[0, 2] = 0;
            Value[0, 3] = 0;
            Value[1, 0] = 0;
            Value[1, 1] = 1;
            Value[1, 2] = 0;
            Value[1, 3] = 0;
            Value[2, 0] = 0;
            Value[2, 1] = 0;
            Value[2, 2] = 1;
            Value[2, 3] = 0;
            Value[3, 0] = l;
            Value[3, 1] = m;
            Value[3, 2] = n;
            Value[3, 3] = 1;
        }

        #endregion
    }
}
