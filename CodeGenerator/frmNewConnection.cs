using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CodeGenerator
{
    public partial class frmNewConnection : Form
    {
        private string connectionString;
        public frmNewConnection()
        {
            InitializeComponent();
        }

        private void cbIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbIdentity = sender as ComboBox;
            if (cbIdentity.SelectedIndex == 1)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void frmNewConnection_Load(object sender, EventArgs e)
        {
            cbIdentity.SelectedIndex = 0;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string msg;
            DbConnection conn = new SqlConnection();
            connectionString = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtDataBase.Text.Trim() + ";";
            if (cbIdentity.SelectedIndex == 1)
            {
                connectionString += "Integrated Security=SSPI";
            }
            else
            {
                connectionString += string.Format("User ID={0};Password={1}", txtUserName.Text.Trim(), txtPassword.Text.Trim());
            }
            SQLHelper.TestConnection(connectionString, out msg);
            if (string.IsNullOrEmpty(msg))
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtDataBase.Text.Trim() + ";";
            if (cbIdentity.SelectedIndex == 1)
            {
                connectionString += "Integrated Security=SSPI";
            }
            else
            {
                connectionString += string.Format("User ID={0};Password={1}", txtUserName.Text.Trim(), txtPassword.Text.Trim());
            }
            List<string> connections = SerializeHelper.XmlDeserialize<List<string>>(Path.Combine(Application.StartupPath , "Connections.xml"));
            connections = connections ?? new List<string>();
            if (!connections.Contains(connectionString))
            {
                connections.Add(connectionString);
                SerializeHelper.XmlSerialize(connections, Path.Combine(Application.StartupPath, "Connections.xml"));
            }

            //XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            //using (FileStream fs = new FileStream("Connections.xml", FileMode.Open, FileAccess.Write))
            //{
            //    serializer.Serialize(fs, connections);
            //}
            MessageBox.Show("保存成功");
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
