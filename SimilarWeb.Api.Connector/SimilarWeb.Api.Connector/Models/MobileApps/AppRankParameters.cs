using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Параметры для вызова метода AppRank.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class AppRankParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/app/{Vendor}/{Application}/rank/app-store-rank";

        /// <summary>
        /// Издатель приложения. 
        /// </summary>        
        public string Vendor { get; set; }

        /// <summary>
        /// Приложение.
        /// </summary>        
        public string Application { get; set; }

        /// <summary>
        /// Страна.
        /// </summary>        
        [ParameterName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Категория приложения.
        /// </summary>        
        [ParameterName("category")]
        public Category Category { get; set; }
        
        /// <summary>
        /// Режим лицензии приложения. 
        /// </summary>        
        [ParameterName("mode")]
        public Mode Mode { get; set; }

        /// <summary>
        /// Устройство.
        /// </summary>        
        [ParameterName("device")]
        public Device Device { get; set; }

        /// <summary>
        /// Количество дней назад от текущей даты, по которой надо ранжировать данные. 
        /// </summary>        
        [ParameterName("duration")]
        public int Duration { get; set; }

        #endregion
    }
}
