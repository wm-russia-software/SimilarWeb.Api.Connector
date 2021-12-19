using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Базовый класс элемента списка стандартных данных.
    /// </summary>
    public abstract class BaseDataListItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        #endregion
    }
}
