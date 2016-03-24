using Newtonsoft.Json;
using System;
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

        public string GetColumnValueAsStringOrEmptyString(DataRow dataRow, int columnIndex)
        {
            if (dataRow[columnIndex] == DBNull.Value)
            {
                return string.Empty;
            }
            return (string)dataRow[columnIndex];
        }

        public int GetColumnValueAsIntegerOrZero(DataRow dataRow, int columnIndex)
        {
            if (dataRow[columnIndex] == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToInt32(dataRow[columnIndex]);
        }
    }
}
