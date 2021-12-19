namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Параметры для вызова метода KeywordCompetitorsOrganic.
    /// </summary>
    /// <seealso cref="BaseParametersWithDomain" />
    public class KeywordCompetitorsOrganicParameters : BaseParametersWithDomain
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/search-competitors/organicsearchcompetitors";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion

    }
}
