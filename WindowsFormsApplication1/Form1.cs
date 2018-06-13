using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        List<byte> lstBuffer = new List<byte>();
        byte[] buffers = new byte[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(GetPic);
            //thread.Start();

            GetAsyncPic();
        }

        private void GetAsyncPic()
        {
            string url = "http://t2.hddhhn.com/uploads/tu/201708/9999/077fe4201a.jpg"; //"http://t2.hddhhn.com/uploads/tu/201806/9999/15e41fa5c2.jpg";// // "http://localhost/1.jpeg";
            var request = WebRequest.Create(url);
            //RequestState rs = new RequestState();
            //rs.Request = 
            request.BeginGetResponse(new AsyncCallback(RespCallBack), request);


            //pictureBox1.Image = Image.FromStream(request.GetResponse().GetResponseStream());
        }

        private void RespCallBack(IAsyncResult ar)
        {
            var request = ar.AsyncState as WebRequest;
            var response = request.EndGetResponse(ar);
            Stream responseStream = response.GetResponseStream();
            IAsyncResult asynchronousInputRead = responseStream.BeginRead(buffers, 0, 8, new AsyncCallback(ReadCallBack), responseStream);
        }

        private void ReadCallBack(IAsyncResult ar)
        {
            Stream responseStream = ar.AsyncState as Stream;
            int read = responseStream.EndRead(ar);
            if (read > 0)
            {
                lstBuffer.AddRange(buffers);
                //buffers = new byte[read];
                responseStream.BeginRead(buffers, 0, 8, new AsyncCallback(ReadCallBack), responseStream);
            }
            else
            {
                lstBuffer.AddRange(buffers);
                Stream s = new MemoryStream(lstBuffer.ToArray());
                pictureBox1.Image = Image.FromStream(s);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                responseStream.Dispose();
            }
        }

        private void GetPic()
        {
            string url = "http://t2.hddhhn.com/uploads/tu/201708/9999/077fe4201a.jpg";// "http://localhost/1.jpeg";
            var request = WebRequest.Create(url);
            pictureBox1.Image = Image.FromStream(request.GetResponse().GetResponseStream());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //private async Task<int> GetAsyncPic()
        //{
        //    MemoryStream content = new MemoryStream();

        //    // 对MSDN发起一个Web请求
        //    var webRequest = WebRequest.Create("http://msdn.microsoft.com/zh-cn/");
        //    if (webRequest != null)
        //    {
        //        // 返回回复结果
        //        using (WebResponse response = await webRequest)
        //        {
        //            using (Stream responseStream = response.GetResponseStream())
        //            {
        //                await responseStream.CopyToAsync(content);
        //            }
        //        }
        //    }
        //}
    }
}
