using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Базовый класс ответа.
    /// </summary>
    /// <typeparam name="TBaseSegment">Тип запршиваемого сегмента.</typeparam>
    public abstract class BaseResponse<TBaseSegment> where TBaseSegment : BaseSegment
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("segments")]
        public List<TBaseSegment> Segments { get; set; }

        #endregion
    }
}
