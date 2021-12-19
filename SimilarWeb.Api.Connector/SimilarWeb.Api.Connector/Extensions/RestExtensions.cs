using System.Net.Http;

namespace SimilarWeb.Api.Connector.Extensions
{
    /// <summary>
    /// Класс расширения для HttpMethod.
    /// </summary>
    internal static class RestExtensions
    {
        #region Методы расширения        

        /// <summary>
        /// Преобразование типа HTTP запроса .NET в тип RESTSharp. 
        /// </summary>
        /// <param name="httpMethod">HTTP-метод</param>
        /// <returns></returns>
        public static RestSharp.Method ToRestMethod(this HttpMethod httpMethod)
        {
            return httpMethod.Method.ToUpper() switch
            {
                "GET" => RestSharp.Method.GET,
                "POST" => RestSharp.Method.POST,
                "PUT" => RestSharp.Method.PUT,
                _ => throw new System.NotImplementedException()
            };
        }

        #endregion
    }
}
