using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class frmOutputCode : Form
    {
        private string _code;
        public frmOutputCode(string code)
        {
            _code = code;
            InitializeComponent();
        }

        private void frmOutputCode_Load(object sender, EventArgs e)
        {
            rtbCode.Text = _code;
            HighLightCode();
        }

        private void HighLightCode()
        {
            string keyword = @"\b(using|namespace|public|partial|class|private|string|object|void|in|new|while|foreach|for|int|double|decimal|bool|byte|short|float|continue|return|null|true|false|get|set|base|protected)\b";
            Regex reg = new Regex(keyword);
            MatchCollection mc = reg.Matches(rtbCode.Text);
            foreach (Match m in mc)
            {
                rtbCode.Select(m.Index, m.Length);
                rtbCode.SelectionColor = Color.Blue;
                rtbCode.SelectionStart = 0;
            }
            rtbCode.SelectionLength = 0;
        }
    }
}
