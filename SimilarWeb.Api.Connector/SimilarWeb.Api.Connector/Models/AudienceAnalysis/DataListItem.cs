using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Элемент списка из ответа на вызов метода NewVsReturningResponse.
    /// </summary>
    public class DataListItem
    {
        #region Свойства 

        [JsonProperty("graph")]
        public Dictionary<DateTime, GraphDataListItem> Graph { get; set; }

        [JsonProperty("total")]
        public TotalItem Total { get; set; }

        #endregion
    }
}
