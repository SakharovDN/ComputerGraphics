namespace LabWork2
{
    using System.ComponentModel;

    public enum LineType
    {
        [Description("Сплошная")]
        Solid,

        [Description("Штриховая")]
        Dashed,

        [Description("Пунктирная")]
        Dotted,
    }
}
