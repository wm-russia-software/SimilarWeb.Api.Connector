using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Элемент списка сегментов.
    /// </summary>
    public class ListSegmentsSegment
    {
        #region Свойства

        [JsonProperty("creator_email")]
        public string CreatorEmail { get; set; }

        [JsonProperty("segment_id")]
        public string SegmentId { get; set; }

        [JsonProperty("segment_name")]
        public string SegmentName { get; set; }

        [JsonProperty("segment_type")]
        public string SegmentType { get; set; }

        [JsonProperty("creator_user_id")]
        public string CreatorUserId { get; set; }

        [JsonProperty("creation_time")]
        public string CreationTime { get; set; }

        [JsonProperty("creation_type")]
        public string CreationType { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("last_updated_time")]
        public DateTime LastUpdatedTime { get; set; }

        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }

        #endregion
    }
}
