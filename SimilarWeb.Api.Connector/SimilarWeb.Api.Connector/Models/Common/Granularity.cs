namespace SimilarWeb.Api.Connector.Models.Common
{
    /// <summary>
    /// Временная гранулярность
    /// </summary>
    public enum Granularity
    {
        /// <summary>
        /// Ежемесячная
        /// </summary>
        [ParameterName("monthly")]
        Monthly = 0,

        /// <summary>
        /// Дневная
        /// </summary>
        [ParameterName("daily")]
        Daily = 1
    }
}
