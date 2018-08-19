using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Person> lstPersons = new List<Person>();
            lstPersons.Add(new Person {Age =20, English =  70,Language = 60,Mathematics =  90,Name = "张三"});
            lstPersons.Add(new Person { Age = 22, English = 80, Language = 75, Mathematics = 80, Name = "李四" });
            gridControl1.DataSource = lstPersons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridControl1.ExportToXlsx("1.xlsx");
            MessageBox.Show("ok");
        }
    }
}
