using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INTMA_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridBind();
            InsertDataTableToDB();
            DbToCsv();
        }

        public DataTable CsvToDataTable(string fileName)
        {
            DataTable result = new DataTable();
            FileInfo fileInfo = new FileInfo(fileName);
            string tableName = fileInfo.Name;
            string folderName = fileInfo.DirectoryName;

            string connectionString = "Provider=Microsoft.Jet.OleDb.4.0;" +
                                      "Data Source=" + folderName + ";" +
                                      "Extended Properties=\"Text;" +
                                      "HDR=YES;" +
                                      "FMT=Delimited\"";

            using (OleDbConnection connection =
                new OleDbConnection(connectionString))
            {
                connection.Open();
                string sqlStatement = "SELECT * FROM " + tableName;

                using (OleDbDataAdapter adapter =
                    new OleDbDataAdapter(sqlStatement, connection))
                {
                    result = new DataTable(tableName);
                    adapter.Fill(result);
                }
            }

            return result;
        }

        private void InsertDataTableToDB()
        {

            SqlConnection myConnection = new SqlConnection(GetConnStr());
            string filePath = "C:\\file2.csv";

            DataTable table = CsvToDataTable(filePath);
            string tableName = "dbo.Table_3";
            myConnection.Open();

            using (SqlBulkCopy bulkcopy = new SqlBulkCopy(myConnection))
            {
                foreach (DataColumn col in table.Columns)
                    bulkcopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);

                bulkcopy.DestinationTableName = tableName;

                try
                {
                    bulkcopy.WriteToServer(table);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + tableName + " ", myConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid2.DataSource = dt;
            myConnection.Close();

        }

        private void DbToCsv()
        {
            SqlConnection myConnection = new SqlConnection(GetConnStr());
            string filePath = "C:\\Users\\Radevich\\Desktop\\file3.csv";

            string tableName = "dbo.Table_4";

            myConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + tableName + " ", myConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid3.DataSource = dt;
            myConnection.Close();

            WriteToCsv(filePath, dt);

        }

        private void WriteToCsv(string filePath, DataTable dt)
        {

            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);

            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, sb.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //string filePath = "C:\\file2.csv";

            //dataGrid1.DataSource = OpenCsvFileAsDataTable(filePath, true);
        }

        private void dataGridBind()
        {
            string filePath = "C:\\Users\\Radevich\\Desktop\\file2.csv";

            dataGrid1.DataSource = CsvToDataTable(filePath);
        }


        private static string GetConnStr()
        {
            return "server=МОРОЗОВ-ПК\\SQLEXPRESS;" +
                "Trusted_Connection=yes;" +
                "database=test; " +
                "connection timeout=30";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

