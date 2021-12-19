using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Ответ на вызов метода GetAppDetails. Содержит заголовок, изображение, издателя, цену, основную категорию, идентификатор основной категории и рейтинг для запрошенного приложения.
    /// </summary>
    /// <seealso cref="BaseResponseWithLastUpdate&lt;TRequest&gt;" />
    public class AppDetailsResponse : BaseResponseWithLastUpdate<CategoryWithApIdRequest>
    {
        #region Свойства

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("main_category")]
        public string MainCategory { get; set; }

        [JsonProperty("main_category_id")]
        public string MainCategoryId { get; set; }

        [JsonProperty("rating")]
        public decimal Rating { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("in_app_purchase")]
        public bool InAppPurchase { get; set; }

        #endregion
    }
}
