using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.IndustryAnalysis
{
    /// <summary>
    ///  Базовый класс ответа. 
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public abstract class BaseResponse<TRequest> where TRequest : Request
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta<TRequest> Meta { get; set; }

        [JsonProperty("top_sites")]
        public List<TopSitesDataListItem> TopSites { get; set; }

        #endregion
    }
}
