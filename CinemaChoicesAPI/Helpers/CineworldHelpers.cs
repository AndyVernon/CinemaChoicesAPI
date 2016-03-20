using Newtonsoft.Json;
using System.Data;
using System.Net;

namespace CinemaChoicesAPI.Helpers
{
    public class CineworldHelpers
    {
        public DataTable ReadJsonIntoDataTable(string url, string tableName)
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(content);
            DataTable dataTable = dataSet.Tables[tableName];
            return dataTable;
        }
    }
}
