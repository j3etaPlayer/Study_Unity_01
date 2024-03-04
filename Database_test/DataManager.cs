using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace Database_test
{
    internal class DataManager
    {
        // json을 저장하는 기능 => button save
        public static void SaveToJson(DataGridView dataGridView, string filePath, string tableName)
        {
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn col in  dataGridView.Columns)
            {
                dataTable.Columns.Add(col.HeaderText, col.ValueType);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }
            DataJson dataJson = new DataJson();
            dataJson.dt = dataTable;
            dataJson.tableName = tableName;

            string jsonData = JsonConvert.SerializeObject(dataJson);
            File.WriteAllText(filePath, jsonData);
        }
        
        // json을 불러오는 기능 => button load
        public static DataJson LoadToJson(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            DataJson dataJson = JsonConvert.DeserializeObject<DataJson>(jsonData);

            return dataJson;
        }

    }

    [Serializable]
    public class DataJson
    {
        public DataTable dt;
        public string tableName;
    }
}
