using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Элемент списка с детализацией загрузок. 
    /// </summary>
    public class DownloadDataListItem
    {
        #region Свойства

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("downloads")]
        public decimal Downloads { get; set; }

        #endregion

    }
}
