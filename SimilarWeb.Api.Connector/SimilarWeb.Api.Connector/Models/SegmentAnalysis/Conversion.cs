using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Страна и диапазон данных.
    /// </summary>
    public class Conversion
    {
        #region Свойства

        [JsonProperty("countries")]
        public Dictionary<string, ConversionAnalysisDates> Countries { get; set; }

        #endregion
    }

}
