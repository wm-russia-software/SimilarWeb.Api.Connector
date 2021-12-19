namespace SimilarWeb.Api.Connector.Models.Common
{
    /// <summary>
    /// Указываемый формат ответа от API
    /// </summary>
    public enum ResponseFormat
    {
        /// <summary>
        /// Json
        /// </summary>
        [ParameterName("json")]
        Json = 0,

        /// <summary>
        /// Xml
        /// </summary>
        [ParameterName("xml")]
        Xml = 1
    }
}
