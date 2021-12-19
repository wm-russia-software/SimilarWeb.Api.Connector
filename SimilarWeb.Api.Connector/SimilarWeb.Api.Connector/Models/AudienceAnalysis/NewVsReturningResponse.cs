using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Ответ на вызов метода GetNewVsReturning. Содержит анализ абсолютного количества и процента новых и вернувшихся пользователей, посещающих целевой веб-сайт.
    /// </summary>
    public class NewVsReturningResponse
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta<NewVsReturningRequest> Meta { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, DataListItem> DataList { get; set; }

        #endregion
    }
}
