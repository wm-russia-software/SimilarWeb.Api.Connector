using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopTrafficSources. Содержит подробный обзор источников трафика с разбивкой по типу источника и доле трафика за выбранный период времени.
    /// </summary>
    /// <seealso cref="BaseVisitsResponse" />
    public class DesktopTrafficSourcesResponse : BaseVisitsResponse
    {
        #region Свойства

        [JsonProperty("overview")]
        public List<Overview> Overview { get; set; }

        #endregion
    }
}
