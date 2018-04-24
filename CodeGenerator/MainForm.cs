using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private string _connectionString;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadAllTable_Click(object sender, EventArgs e)
        {
            _connectionString = cbConnections.Text.Trim();
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                MessageBox.Show("数据库连接为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLHelper.ConnectionString = _connectionString;
            DataSet ds = SQLHelper.ExecuteDataset("SELECT O.name AS [TableName],P.value AS [Description] FROM sys.objects O LEFT JOIN sys.extended_properties P ON O.object_id = P.major_id AND P.class = 1 AND P.minor_id = 0 AND P.name = 'MS_Description' WHERE type = 'U' ORDER BY O.name");
            dgvTables.DataSource = ds.Tables[0];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //dgvTables.AutoGenerateColumns = false;
            LoadConnections();
        }

        private void LoadConnections()
        {
            cbConnections.Items.Clear();
            List<string> connections = SerializeHelper.XmlDeserialize<List<string>>(Path.Combine(Application.StartupPath, "Connections.xml"));
            connections = connections ?? new List<string>();
            string[] arrs = connections.ToArray();
            cbConnections.Items.AddRange(arrs);
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            frmNewConnection frm = new frmNewConnection();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadConnections();
            }
        }

        private void dgvTables_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvTables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tableName = dgvTables.Rows[e.RowIndex].Cells["TableName"].Value.ToString();
            DataTable dt = GetTableInfo(tableName);
            dgvTableInfo.DataSource = dt;
        }

        private DataTable GetTableInfo(string tableName)
        {
            SQLHelper.ConnectionString = _connectionString;
            string sql = @"SELECT col.name AS ColumnName ,
                ISNULL(ep.[value], '') AS [Description] ,
                t.name AS DataType ,
                col.length AS [DataLength],
                ISNULL(COLUMNPROPERTY(col.id, col.name, 'Scale'), 0) AS [Precision] ,
                COLUMNPROPERTY(col.id, col.name, 'IsIdentity') as [Identity],
                CASE WHEN EXISTS ( SELECT 1
                FROM dbo.sysindexes si
                INNER JOIN dbo.sysindexkeys sik ON si.id = sik.id
                AND si.indid = sik.indid
                INNER JOIN dbo.syscolumns sc ON sc.id = sik.id
                AND sc.colid = sik.colid
                INNER JOIN dbo.sysobjects so ON so.name = si.name
                AND so.xtype = 'PK'
                WHERE sc.id = col.id
                AND sc.colid = col.colid ) THEN 1
                ELSE 0
                END AS [PrimaryKey] ,
                col.isnullable as IsNullable,
                ISNULL(comm.text, '') AS [DefaultValue]
                FROM dbo.syscolumns col
                LEFT JOIN dbo.systypes t ON col.xtype = t.xusertype
                inner JOIN dbo.sysobjects obj ON col.id = obj.id
                AND obj.xtype = 'U'
                AND obj.status >= 0
                LEFT JOIN dbo.syscomments comm ON col.cdefault = comm.id
                LEFT JOIN sys.extended_properties ep ON col.id = ep.major_id
                AND col.colid = ep.minor_id
                AND ep.name = 'MS_Description'
                LEFT JOIN sys.extended_properties epTwo ON obj.id = epTwo.major_id
                AND epTwo.minor_id = 0
                AND epTwo.name = 'MS_Description'
                WHERE obj.name = '{0}'
                ORDER BY col.colorder ;";
            sql = string.Format(sql, tableName);
            DataSet ds = SQLHelper.ExecuteDataset(sql, null);
            return ds.Tables[0];
        }

        private void btnGenerateModel_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count != 1)
            {
                return;
            }
            else
            {
                int rowIndex = dgvTables.SelectedRows[0].Index;
                string tableName = dgvTables.Rows[rowIndex].Cells["TableName"].Value.ToString();
                string description = dgvTables.Rows[rowIndex].Cells["Description1"].Value.ToString();
                DataTable dt = GetTableInfo(tableName);
                string str = GetModelCode(tableName, dt, description, true);
                frmOutputCode frm = new frmOutputCode(str);
                frm.ShowDialog();
            }
        }

        private string GetModelCode(string tableName, DataTable dt, string description, bool simplifyProperty = true)
        {
            description = description ?? "";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// " + description);
            sb.AppendLine("/// </summary>");
            sb.AppendLine("public class " + tableName);
            sb.AppendLine("{");
            foreach (DataRow r in dt.Rows)
            {
                sb.AppendLine("\t" + GetPropertyCode(r));
            }

            sb.AppendLine("}");
            return sb.ToString();
        }

        private string GetPropertyCode(DataRow r)
        {
            string str = "/// <summary>\n";
            str += "\t/// " + r["Description"].ToString() + "\n";
            str += "\t/// </summary>\n";
            str += "\tpublic {0} " + r["ColumnName"].ToString() + "{{ get; set;}}";
            str = string.Format(str, GetDataType(r));
            return str;
        }

        private string GetDataType(DataRow r)
        {
            string str = "";
            bool isValueType = true;
            string dbDataType = r["DataType"].ToString();
            int isNull = (int)r["IsNullable"];  //1:可null， 0:不可null
            switch (dbDataType)
            {
                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                    str = "string"; isValueType = false; break;
                case "bigint": str = "long"; break;
                case "bit": str = "bool"; break;
                case "uniqueidentifier": str = "Guid"; isValueType = false; break;
                case "tinyint": str = "byte"; break;
                case "smallint": str = "short"; break;
                case "int": str = "int"; break;
                case "decimal":
                case "numeric": str = "decimal"; break;
                case "float":
                case "momey": str = "double"; break;
                case "real": str = "float"; break;
                case "datetime":
                case "datetime2": str = "DateTime"; break;
                default:
                    break;
            }
            if (isValueType && isNull == 1)
            {
                str += "?";
            }
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count != 1)
            {
                return;
            }
            else
            {
                int rowIndex = dgvTables.SelectedRows[0].Index;
                string tableName = dgvTables.Rows[rowIndex].Cells[0].Value.ToString();
                DataTable dt = GetTableInfo(tableName);
                string str = GetMappingCode(tableName, dt);
                frmOutputCode frm = new frmOutputCode(str);
                frm.ShowDialog();
            }
        }
        /// <summary>
        ///  获取映射
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string GetMappingCode(string tableName, DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System.Data.Entity.ModelConfiguration;\n");
            sb.AppendFormat("public class {0}Map : EntityTypeConfiguration<{0}>\n", tableName);
            sb.AppendLine("{");
            //构造函数
            sb.AppendLine("\tpublic " + tableName + "Map()");
            sb.AppendLine("\t{");
            //Table
            sb.AppendLine("\t\tToTable(\"" + tableName + "\");");
            //Primark Key
            DataRow[] rows = dt.Select("PrimaryKey=1");
            if (rows.Length == 1)
            {
                sb.AppendLine("\t\tHasKey(m => m." + rows[0]["ColumnName"].ToString() + ");");
            }
            else if (rows.Length > 1)
            {
                sb.AppendFormat("\t\ttHasKey(m => new {0});\n", "{" + string.Join(",", rows.Select(dr => "m." + dr.Field<string>("ColumnName")).ToArray()));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (r["PrimaryKey"].ToString() == "1")
                {
                    continue;
                }
                else
                {
                    string dataType = r["DataType"].ToString().ToLower();
                    int dataLength = Convert.ToInt32(r["DataLength"]);
                    string[] stringTypes = { "char", "nchar", "varchar", "nvarchar" };
                    if (stringTypes.Contains(dataType) && dataLength != -1)
                    {
                        sb.AppendLine("\t\tProperty(m => m." + r["ColumnName"].ToString() + ").HasMaxLength(" + dataLength + ");");
                    }
                    else
                    {
                        sb.AppendLine("\t\tProperty(m => m." + r["ColumnName"].ToString() + ");");
                    }
                }
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            return sb.ToString();
        }

        private void btnGenerateDbContext_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count != 1)
            {
                return;
            }

            int rowIndex = dgvTables.SelectedRows[0].Index;
            string tableName = dgvTables.Rows[rowIndex].Cells[0].Value.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System.Data.Entity;");
            sb.AppendLine("using System.Data.Entity.Infrastructure;");
            sb.AppendLine("public class EFContext : DbContext");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic EFContext():base(\"name=DefaultConnection\")");
            sb.AppendLine("\t{");
            sb.AppendLine("\t}");
            sb.AppendLine("\tpublic DbSet<" + tableName + "> " + tableName + "s  {get;set;}");
            sb.AppendLine("\tprotected override void OnModelCreating(DbModelBuilder modelBuilder)");
            sb.AppendLine("\t{");
            sb.AppendLine("\t\tDatabase.SetInitializer<EFContext>(null);");
            sb.AppendLine("\t\tmodelBuilder.Configurations.Add(new "+tableName+"Map());");
            sb.AppendLine("\t\tbase.OnModelCreating(modelBuilder);");
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            frmOutputCode frm = new frmOutputCode(sb.ToString());
            frm.ShowDialog();
        }

        private void btnCopyConnection_Click(object sender, EventArgs e)
        {
            frmOutputCode frm = new frmOutputCode(cbConnections.Text);
            frm.ShowDialog();
        }


    }
}
