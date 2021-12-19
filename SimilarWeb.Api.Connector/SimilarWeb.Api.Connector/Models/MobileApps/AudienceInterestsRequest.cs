using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Запрос из метаданных в ответе на вызов метода. 
    /// </summary>
    /// <seealso cref="BaseCategoryRequest" />
    public class AudienceInterestRequest : BaseCategoryRequest
    {
        #region Свойства

        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        #endregion
    }
}
