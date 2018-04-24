using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeGenerator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadAllTable_Click(object sender, RoutedEventArgs e)
        {
            SQLHelper.ConnectionString = txtConnectionString.Text.Trim();
            DataSet ds = SQLHelper.ExecuteDataset("select TABLE_NAME from INFORMATION_SCHEMA.TABLES");
            dgTables.ItemsSource = ds.Tables[0].DefaultView;

        }

        private void btnTestConnect_Click(object sender, RoutedEventArgs e)
        {
            string msg;
            SQLHelper.ConnectionString = txtConnectionString.Text.Trim();
            SQLHelper.TestConnection(out msg);
            if (string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnCreateCode_Click(object sender, RoutedEventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("public class A");
            //sb.AppendLine("{");
            //sb.AppendWithTab(1, "public int Age {get;set;}");
            //sb.AppendWithTab(1, "public string Name");
            //sb.AppendWithTab(1, "{");
            //sb.AppendWithTab(2, "get");
            //sb.AppendWithTab(2, "{");
            //sb.AppendWithTab(3, "return _name;");
            //sb.AppendWithTab(2, "}");
            //sb.AppendWithTab(2, "set");
            //sb.AppendWithTab(2, "{");
            //sb.AppendWithTab(3, "_name = value;");
            //sb.AppendWithTab(2, "}");
            //sb.AppendWithTab(1, "}");
            //sb.AppendLine("}");
            //MessageBox.Show(sb.ToString());
            //return;
            DataRowView r = dgTables.SelectedValue as DataRowView;
            if (r != null)
            {
                string tableName = r["TABLE_NAME"].ToString();
                DataTable dt = SQLHelper.ExecuteDataset("select COLUMN_NAME,IS_NULLABLE,DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME=@TABLE_NAME", new SqlParameter("TABLE_NAME", tableName)).Tables[0];
                GenerateModelCode(tableName,dt);
            }
        }

        private void GenerateModelCode(string tableName, DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("public partial class " + tableName);
            sb.AppendLine("{");
            foreach (DataRow  r in dt.Rows)
            {
                sb.AppendWithTab(1, GetPropertyDefine(r));
            }
            sb.AppendLine("}");
            Console.WriteLine(sb.ToString());
        }

        private string GetPropertyDefine(DataRow r)
        {
            return "public " + GetDataType(r["DATA_TYPE"].ToString(), r["IS_NULLABLE"].ToString()) + " " + r["COLUMN_NAME"].ToString() + " {get;set;}";
        }

        private string GetDataType(string dbDataType, string isNull)
        {
            string str = "";
            bool isValueType = true;
            switch (dbDataType)
            {
                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                    str = "string";isValueType =false; break;
                case "bigint": str = "long"; break;
                case "bit": str = "bool"; break;
                case "uniqueidentifier": str = "Guid"; isValueType=false; break;
                case "tinyint": str = "byte"; break;
                case "smallint": str = "short"; break;
                case "int": str = "int"; break;
                case "decimal":
                case "numeric":str = "decimal";break;
                case "float":
                case "momey": str = "double"; break;
                case "real": str = "float"; break;
                case "datetime":
                case "datetime2": str = "DateTime"; break;
                default:
                    break;
            }
            if (isValueType && isNull == "YES")
            {
                str += "?";
            }
            return str;
        }
    }
}
