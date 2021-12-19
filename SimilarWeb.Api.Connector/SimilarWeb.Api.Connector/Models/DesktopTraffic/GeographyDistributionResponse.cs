using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetGeographyDistribution. Содержит долю трафика настольных компьютеров с разбивкой по странам за выбранные даты (мин. 1 месяц). 
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;"></seealso>
    public class GeographyDistributionResponse : BaseResponse<GeographyRequest>
    {
        #region Свойства

        [JsonProperty("records")]
        public List<GeographyDataRecord> Records { get; set; }

        #endregion
    }
}
