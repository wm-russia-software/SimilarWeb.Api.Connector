using SimilarWeb.Api.Connector.Models.SalesSolution;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов SalesSolution.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class SalesSolution : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public SalesSolution(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public SalesSolution(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает набор данных о домене для всего мира.
        /// </summary>
        /// <param name="leadEnrichmentParameters">Параметры запроса.</param>
        /// <returns></returns>
        public LeadEnrichmentResponse GetLeadEnrichment(LeadEnrichmentParameters leadEnrichmentParameters)
        {
            return Invoke<LeadEnrichmentResponse>(leadEnrichmentParameters);
        }

        /// <summary>
        /// Возвращает установленные в настоящее время технологии для домена (обновляется еженедельно по воскресеньям).
        /// </summary>
        /// <param name="technographicsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public TechnographicsResponse GetTechnographics(TechnographicsParameters technographicsParameters)
        {
            return Invoke<TechnographicsResponse>(technographicsParameters);
        }

        #endregion
    }
}
