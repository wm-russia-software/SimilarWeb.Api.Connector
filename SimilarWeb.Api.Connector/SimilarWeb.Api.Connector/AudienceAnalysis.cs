using SimilarWeb.Api.Connector.Models.AudienceAnalysis;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов AudienceAnalysis.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class AudienceAnalysis : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public AudienceAnalysis(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public AudienceAnalysis(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает список дополнительных веб-сайтов, которые часто посещались одними и теми же посетителями данного домена в течение сеанса просмотра, а также их оценку близости и совпадение (средний % посетителей, которые посетили оба сайта в один и тот же день).
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AudienceInterestsResponse GetAudienceInterest(AudienceInterestsParameters requestParameters)
        {
            return Invoke<AudienceInterestsResponse>(requestParameters);
        }

        /// <summary>
        /// Возвращает сравнение аудитории с конкурентами, для измерения размера рынка и уточнения в предпочтениях аудитории.
        /// </summary>
        /// <param name="audienceOverlapParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AudienceOverlapResponse GetAudienceOverlap(AudienceOverlapParameters audienceOverlapParameters)
        {
            return Invoke<AudienceOverlapResponse>(audienceOverlapParameters);
        }

        /// <summary>
        /// Возвращает разбивку по возрастным группам для трафика, посещающего домен.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopDemographicsAgeResponse GetDesktopDemographicsAge(DesktopDemographicsAgeParameters requestParameters)
        {
            return Invoke<DesktopDemographicsAgeResponse>(requestParameters);
        }

        /// <summary>
        /// Возвращает разбивку по полу для трафика, посещающего домен.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopDemographicsGenderResponse GetDesktopDemographicsGender(DesktopDemographicsGenderParameters requestParameters)
        {
            return Invoke<DesktopDemographicsGenderResponse>(requestParameters);
        }

        /// <summary>
        /// Возвращает разбивку по возрастным группам для трафика, посещающего домен.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebDemographicsAgeResponse GetMobileWebDemographicsAge(MobileWebDemographicsAgeParameters requestParameters)
        {

            return Invoke<MobileWebDemographicsAgeResponse>(requestParameters);
        }

        /// <summary>
        /// Возвращает разбивку по полу для трафика, посещающего домен.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebDemographicsGenderResponse GetMobileWebDemographicsGender(MobileWebDemographicsGenderParameters requestParameters)
        {

            return Invoke<MobileWebDemographicsGenderResponse>(requestParameters);
        }

        /// <summary>
        /// Возвращает анализ абсолютного количества и процента новых и вернувшихся пользователей, посещающих целевой веб-сайт.
        /// </summary>
        /// <param name="newVsReturningParameters">Параметры запроса.</param>
        /// <returns></returns>
        public NewVsReturningResponse GetNewVsReturning(NewVsReturningParameters newVsReturningParameters)
        {

            return Invoke<NewVsReturningResponse>(newVsReturningParameters);
        }

        #endregion
    }
}
