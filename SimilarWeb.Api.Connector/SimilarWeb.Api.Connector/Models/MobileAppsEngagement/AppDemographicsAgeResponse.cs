using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetAppDemographicsAge. Содержит разбивку демографических данных приложений по возрастным группам.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class AppDemographicsAgeResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("age_18_to_24")]
        public decimal Age18To24 { get; set; }

        [JsonProperty("age_25_to_34")]
        public decimal Age25To34 { get; set; }

        [JsonProperty("age_35_to_44")]
        public decimal Age35To44 { get; set; }

        [JsonProperty("age_45_to_54")]
        public decimal Age45To54 { get; set; }

        [JsonProperty("age_55_plus")]
        public decimal Age55Plus { get; set; }

        #endregion
    }
}
