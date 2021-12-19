namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Параметры для вызова метода DeduplicatedAudience.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class DeduplicatedAudienceParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/dedup/deduplicated-audiences";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>
        public string Website { get; set; }

        #endregion
    }
}
