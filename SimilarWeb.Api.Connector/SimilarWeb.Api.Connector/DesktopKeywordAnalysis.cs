using SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов DesktopKeywordAnalysis.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class DesktopKeywordAnalysis : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public DesktopKeywordAnalysis(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public DesktopKeywordAnalysis(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Вызов метода GetKeywordAnalysisOrganicCompetitors
        /// </summary>
        /// <param name="keywordAnalysisOrganicCompetitorsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public KeywordAnalysisOrganicCompetitorsResponse GetKeywordAnalysisOrganicCompetitors(KeywordAnalysisOrganicCompetitorsParameters keywordAnalysisOrganicCompetitorsParameters)
        {
            return Invoke<KeywordAnalysisOrganicCompetitorsResponse>(keywordAnalysisOrganicCompetitorsParameters);
        }

        /// <summary>
        /// Вызов метода GetKeywordAnalysisPaidCompetitors
        /// </summary>
        /// <param name="keywordAnalysisPaidCompetitorsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public KeywordAnalysisPaidCompetitorsResponse GetKeywordAnalysisPaidCompetitors(KeywordAnalysisPaidCompetitorsParameters keywordAnalysisPaidCompetitorsParameters)
        {
            return Invoke<KeywordAnalysisPaidCompetitorsResponse>(keywordAnalysisPaidCompetitorsParameters);
        }

        /// <summary>
        /// Возвращает список веб-сайтов, конкурирующих за те же самые ключевые слова, что и данный домен, и оценку конкуренции.
        /// </summary>
        /// <param name="keywordCompetitorsOrganicParameters">Параметры запроса.</param>
        /// <returns></returns>
        public KeywordCompetitorsOrganicResponse GetKeywordCompetitorsOrganic(KeywordCompetitorsOrganicParameters keywordCompetitorsOrganicParameters)
        {
            return Invoke<KeywordCompetitorsOrganicResponse>(keywordCompetitorsOrganicParameters);
        }

        /// <summary>
        /// Возвращает список веб-сайтов, конкурирующих за те же платные ключевые слова, что и данный домен, и оценку конкуренции.
        /// </summary>
        /// <param name="keywordCompetitorsPaidParameters">Параметры запроса.</param>
        /// <returns></returns>
        public KeywordCompetitorsPaidResponse GetKeywordCompetitorsPaid(KeywordCompetitorsPaidParameters keywordCompetitorsPaidParameters)
        {
            return Invoke<KeywordCompetitorsPaidResponse>(keywordCompetitorsPaidParameters);
        }

        #endregion
    }
}
