using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.Utilities
{
    /// <summary>
    /// Временной интервал данных. 
    /// </summary>
    public class SnapshotInterval
    {
        #region Свойства

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        #endregion
    }
}
