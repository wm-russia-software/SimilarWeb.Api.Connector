namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Параметры для вызова метода AppDemographicsGender.
    /// </summary>
    /// <seealso cref="BaseShortParameters" />
    public class AppDemographicsGenderParameters : BaseShortParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/app/{Vendor}/{Application}/demographics/gender";

        /// <summary>
        /// Издатель приложения. 
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// Приложение.
        /// </summary>        
        public string Application { get; set; }

        #endregion
    }
}
