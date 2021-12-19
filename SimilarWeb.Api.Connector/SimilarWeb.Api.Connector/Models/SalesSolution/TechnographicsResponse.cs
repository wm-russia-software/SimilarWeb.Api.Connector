using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Ответ на вызов метода GetTechnographics. Содержит установленные в настоящее время технологии для домена (обновляется еженедельно по воскресеньям).
    /// </summary>
    /// <seealso cref="BaseSalesSolution" />
    public class TechnographicsResponse : BaseSalesSolution
    {
        #region Свойства

        [JsonProperty("site_name")]
        public string SiteName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("technologies")]
        public List<Technology> Technologies { get; set; }

        #endregion
    }
}
