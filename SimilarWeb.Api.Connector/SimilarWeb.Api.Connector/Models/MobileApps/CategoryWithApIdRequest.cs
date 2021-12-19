using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Базовый тип запроса из метаданных с категорией и идентификатором приложения.
    /// </summary>
    /// <seealso cref="BaseCategoryRequest" />
    public class CategoryWithApIdRequest : BaseCategoryRequest
    {
        #region Свойства

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        #endregion

    }
}
