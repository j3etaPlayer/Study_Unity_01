using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_test
{
    public partial class Database : Form
    {
        // DataSet - DataTable - DataColumn, DataRow
        DataSet ds = new DataSet();

        public Database()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            IDText.Text = "";
            NameText.Text = "";
            RaceText.Text = "";
            RegionSelectbox.Text = "";
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // bool이 true이면 이미 생성한 데이터가 있으니 그 데이터를 불러와서 추가로 데이터를 만들고
            // bool이 false면 처음 생성한 데이터이기 때문에 데이터를 생성해주면 된다.

            bool chackIsTable = ds.Tables.Contains(RegionSelectbox.Text) == true ? true : false;

            DataTable dt = null;
            if (!chackIsTable)
            {
                dt = new DataTable(ListCombobox.Text);

                DataColumn columeID = new DataColumn("ID", typeof(string));
                DataColumn columeName = new DataColumn("Name", typeof(string));
                DataColumn columeRace = new DataColumn("Race", typeof(string));
                DataColumn columeRegion = new DataColumn("Region", typeof(string));

                dt.Columns.Add(columeID);
                dt.Columns.Add(columeName);
                dt.Columns.Add(columeRace);
                dt.Columns.Add(columeRegion);
            }
            else
            {
                dt = ds.Tables[RegionSelectbox.Text];
            }

            // 생성할 데이터를 row에 입력한 후
            DataRow row = dt.NewRow();
            row["ID"] = IDText.Text;
            row["Name"] = NameText.Text;
            row["Race"] = RaceText.Text;
            row["Region"] = RegionSelectbox.Text;

            // 데이터 테이블이 이미 존재한다면 기존 테이블을 불러온 후 새로운 데이터를 이어서 추가해주고
            // 테이블이 존재하지 않는다면 row를 table에 추가해주면 된다.
            if (chackIsTable)
                ds.Tables[RegionSelectbox.Text].Rows.Add(row);
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }
            
            ViewRefresh();
            // ListCombobox_SelectedIndexChanged(this, null);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int selectRow = DataGridViewInfo.SelectedRows[0].Index;

            ds.Tables[RegionSelectbox.Text].Rows.RemoveAt(selectRow);

            ViewRefresh();
        }

        private void ListCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewInfo.DataSource = ds.Tables[ListCombobox.Text];

            foreach(DataGridViewRow row in DataGridViewInfo.Rows)
                row.HeaderCell.Value = row.Index.ToString();

        }

        private void ViewRefresh()
        {
            DataGridViewInfo.DataSource = ds.Tables[ListCombobox.Text];

            foreach (DataGridViewRow row in DataGridViewInfo.Rows)
                row.HeaderCell.Value = row.Index.ToString();
        }

        private void Btn_DataSave_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Sample\test.txt");
            for (int i = 0; i < DataGridViewInfo.Rows.Count-1; i++)
            {
                for (int j = 0; j < DataGridViewInfo.Columns.Count; j++)
                {
                    writer.Write("\t" + DataGridViewInfo.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine();
            }
            writer.Close();
            MessageBox.Show("데이터가 저장되었음!");
        }

        private void Btn_DataLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Sample\test.txt");
            
            string[] lines = File.ReadAllLines(@"C:\Sample\test.txt");

            DataGridViewInfo.ColumnCount = lines[0].Split('|').Length;

            DataTable dt = new DataTable("1지역");
            dt = new DataTable(ListCombobox.Text);
            ds.Tables.Add(dt);

            DataColumn columeID = new DataColumn("ID", typeof(string));
            DataColumn columeName = new DataColumn("Name", typeof(string));
            DataColumn columeRace = new DataColumn("Race", typeof(string));
            DataColumn columeRegion = new DataColumn("Region", typeof(string));

            dt.Columns.Add(columeID);
            dt.Columns.Add(columeName);
            dt.Columns.Add(columeRace);
            dt.Columns.Add(columeRegion);

            foreach (string line in lines)
            {
                string[] values = line.Split('|');
                DataRow row = dt.NewRow();
                row["ID"] = values[0];
                row["Name"] = values[1];
                row["Race"] = values[2];
                row["Region"] = values[3];

                ds.Tables[ListCombobox.Text].Rows.Add(row);
            }

            ViewRefresh();
        }
    }
}
