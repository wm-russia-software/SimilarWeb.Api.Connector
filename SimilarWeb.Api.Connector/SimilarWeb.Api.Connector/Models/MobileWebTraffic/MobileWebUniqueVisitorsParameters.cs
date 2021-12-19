namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Параметры для вызова метода MobileWebUniqueVisitors.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class MobileWebUniqueVisitorsParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/unique-visitors/mobileweb_unique_visitors";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>
        public string Website { get; set; }

        #endregion
    }
}
