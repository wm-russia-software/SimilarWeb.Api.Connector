using SimilarWeb.Api.Connector.Models.Utilities;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов Utilities.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class Utilities : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public Utilities(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public Utilities(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает оставшиеся обращения, фильтры разрешенных стран и доступные периоды времени для учетной записи.
        /// </summary>
        /// <param name="checkCapabilitiesParameters">Параметры запроса.</param>
        /// <returns></returns>
        public CheckCapabilitiesResponse GetCheckCapabilities(CheckCapabilitiesParameters checkCapabilitiesParameters)
        {
            return Invoke<CheckCapabilitiesResponse>(checkCapabilitiesParameters);
        }

        /// <summary>
        /// Возвращает список всех категорий сайтов SimilarWeb.
        /// </summary>
        /// <param name="listCategoriesParameters">Параметры запроса.</param>
        /// <returns></returns>
        public ListCategoriesResponse GetListCategories(ListCategoriesParameters listCategoriesParameters)
        {
            return Invoke<ListCategoriesResponse>(listCategoriesParameters);
        }

        #endregion
    }
}
