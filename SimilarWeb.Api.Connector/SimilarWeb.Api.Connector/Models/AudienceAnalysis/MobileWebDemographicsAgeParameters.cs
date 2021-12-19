namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Параметры для вызова метода MobileWebDemographicsAge.
    /// </summary>
    /// <seealso cref="BaseParametersWithDomain" />
    public class MobileWebDemographicsAgeParameters : BaseParametersWithDomain
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/demographics-mobile/age";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>
        public string Website { get; set; }

        #endregion
    }
}
