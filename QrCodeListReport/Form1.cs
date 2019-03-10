using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using  Gma.QrCodeNet;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace QrCodeListReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<MyClass> lstData = new List<MyClass>();
            for (int i = 0; i < 4; i++)
            {
                var item = new MyClass { Group = i / 2 };
                item.Qrcode2 = GetQrCode("Hello" + i);
                item.QrCode = GetQrCode("Welcome " + i);
                lstData.Add(item);
            }

            XtraReport1 report = new XtraReport1();
            report.xrPictureBox1.DataBindings.Add("Image", lstData, "QrCode");
            report.xrPictureBox2.DataBindings.Add("Image", lstData, "QrCode2");
            report.xrLabel1.DataBindings.Add("Text", lstData, "Group");
            //report.xrTableCell1.DataBindings.Add("Text", lstData, "Group");
            //GroupField groupField = new GroupField("Group");
            //report.GroupHeader1.GroupFields.Clear();
            //report.GroupHeader1.GroupFields.Add(groupField);
            report.DataSource = lstData;
            ReportPrintTool rpt = new ReportPrintTool(report);
            rpt.ShowPreview(UserLookAndFeel.Default);
        }

        private static Image GetQrCode(string content)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.L);
            QrCode qrCode = encoder.Encode(content);
            FixedModuleSize fixedModule = new FixedModuleSize(4, QuietZoneModules.Two);
            GraphicsRenderer renderer = new GraphicsRenderer(fixedModule, Brushes.Black, Brushes.White);
            using (MemoryStream ms =new MemoryStream())
            {
                renderer.WriteToStream(qrCode.Matrix,ImageFormat.Png,ms
                );
                return Image.FromStream(ms);
            }
        }
    }

    class MyClass
    {
        public Image QrCode { get; set; }
        public Image Qrcode2 { get; set; }
        public int Group { get; set; }
    }
}
