using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Стандартный элемент списка с данными запросов в разрезе времени.
    /// </summary>
    public class DataValueItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        #endregion
    }
}
