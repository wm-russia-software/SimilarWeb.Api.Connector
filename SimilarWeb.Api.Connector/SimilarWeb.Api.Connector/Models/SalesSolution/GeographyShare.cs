using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Элемент списка с георгафическим разделением.
    /// </summary>
    public class GeographyShare
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public List<GeographyShareValueItem> Value { get; set; }

        #endregion
    }
}
