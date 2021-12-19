using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.Utilities
{
    /// <summary>
    /// Список с доступными для клиента возможностями. 
    /// </summary>
    public class CapabilitiesData
    {
        #region Свойства

        [JsonProperty("snapshot_interval")]
        public SnapshotInterval SnapshotInterval { get; set; }

        [JsonProperty("countries")]
        public List<Country> Countries { get; set; }

        #endregion
    }
}
