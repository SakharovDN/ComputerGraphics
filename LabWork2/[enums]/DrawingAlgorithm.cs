namespace LabWork2
{
    using System.ComponentModel;

    public enum DrawingAlgorithm
    {
        [Description("ЦДА")]
        DDA,

        [Description("Несимметричный ЦДА")]
        AsymmetricalDDA,

        [Description("Заливка")]
        Filling,
    }
}
