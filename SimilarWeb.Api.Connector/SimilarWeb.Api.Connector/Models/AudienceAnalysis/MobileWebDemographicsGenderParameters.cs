namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Параметры для вызова метода MobileWebDemographicsGender.
    /// </summary>
    /// <seealso cref="BaseParametersWithDomain" />
    public class MobileWebDemographicsGenderParameters : BaseParametersWithDomain
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/demographics-mobile/gender";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion
    }
}
