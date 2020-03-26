using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVBTool
{
    public partial class LVBTool : Form
    {
        public LVBTool()
        {
            InitializeComponent();
        }

        private void btn_SQLToPG_Click(object sender, EventArgs e)
        {
            this.txt_result.Text = string.Empty;
            string[] oriStr = txt_ori.Lines;
            string objName = this.txt_Var.Text.Trim();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"StringBuilder {objName} = new StringBuilder();");
            foreach (string s in oriStr)
            {
                sb.AppendLine($"{ objName}.AppendLine(\"{s}\");");
            }
            this.txt_result.Text = sb.ToString();
        }

        private void btn_PGToSQL_Click(object sender, EventArgs e)
        {
            this.txt_result.Text = string.Empty;
            string[] oriStr = txt_ori.Lines;
            string objName = this.txt_Var.Text.Trim();
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"StringBuilder {objName} = new StringBuilder();");
            //if(oriStr.Length>0 && oriStr[0].Contains("new StringBuilder()"))

            foreach (string s in oriStr)
            {
                if (!s.Contains("new StringBuilder()"))
                {
                    //sb.AppendLine($"{ objName}.AppendLine(\"{s}\");");
                    sb.AppendLine($"{s.Replace($"{objName}.AppendLine(\"",string.Empty).Replace("\");",string.Empty)}");
                }
            }
            this.txt_result.Text = sb.ToString();
        }
    }
}
