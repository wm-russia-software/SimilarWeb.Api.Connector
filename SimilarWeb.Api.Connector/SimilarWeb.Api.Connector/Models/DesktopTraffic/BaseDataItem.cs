using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Базовый класс с датой. 
    /// </summary>
    public abstract class BaseDataItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        #endregion
    }
}
