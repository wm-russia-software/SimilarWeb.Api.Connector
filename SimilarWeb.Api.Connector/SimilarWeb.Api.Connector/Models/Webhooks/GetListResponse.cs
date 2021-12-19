using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.Webhooks
{
    /// <summary>
    /// Ответ на вызов метода GetList.
    /// </summary>
    public class GetListResponse
    {
        #region Свойства 

        public List<GetListDataListItem> GetListDataListItems { get; set; }

        #endregion
    }
}
