using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Перечисление типов лицензирования. 
    /// </summary>
    public enum Mode
    {
        [ParameterName("free")]
        Free,

        [ParameterName("new_free")]
        NewFree,

        [ParameterName("new_paid")]
        NewPaid,

        [ParameterName("paid")]
        Paid,

        [ParameterName("topgrossing")]
        TopGrossing,

        [ParameterName("topfree")]
        TopFree,

        [ParameterName("topfreeipad")]
        TopFreeIPad,

        [ParameterName("topgrossingipad")]
        TopGrossingIPad,

        [ParameterName("toppaid")]
        TopPaid,

        [ParameterName("toppaidipad")]
        TopPaidIPad

    }
}
