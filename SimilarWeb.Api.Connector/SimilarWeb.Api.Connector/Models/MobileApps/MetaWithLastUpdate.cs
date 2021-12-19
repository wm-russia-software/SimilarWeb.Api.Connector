namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Метаданные ответа с датой обновления. 
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    /// <seealso cref="BaseMetaWithLastUpdate&lt;TRequest&gt;" />
    public class MetaWithLastUpdate<TRequest> : BaseMetaWithLastUpdate<TRequest> where TRequest : BaseRequest
    {

    }
}
