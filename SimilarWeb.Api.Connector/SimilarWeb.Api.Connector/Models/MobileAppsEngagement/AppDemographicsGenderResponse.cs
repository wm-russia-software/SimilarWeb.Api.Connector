using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetAppDemographicsGender. Содержит демографические данные приложений по полу.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class AppDemographicsGenderResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("male")]
        public decimal Male { get; set; }

        [JsonProperty("female")]
        public decimal Female { get; set; }

        #endregion
    }
}
