namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Параметры для вызова метода MobileWebReferrals.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class MobileWebReferralsParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/traffic-sources/mobileweb-referrals";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion
    }
}
