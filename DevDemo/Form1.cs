using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new CityContext())
            {
                List<City> citys = context.Citys.ToList();
                treeList1.DataSource = citys;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (treeList1.FocusedNode != null)
            {
                City c = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as City;
                using (var context = new RainfallContext())
                {
                    context.Rainfalls.Add(new Rainfall {
                        CityId = c.Id,
                        RainfallValue = Convert.ToInt32(txtRainfall.Text.Trim())
                    });
                    context.SaveChanges();
                }
                MessageBox.Show("保存成功");
            }
            
        }
    }
}
