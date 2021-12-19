﻿using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Запрос из метаданных ответа. 
    /// </summary>
    public class Request
    {
        #region Свойства

        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        #endregion
    }
}