using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTools.UC
{
    public partial class UC_Validator : UserControl
    {
        public UC_Validator()
        {
            InitializeComponent();
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "選擇檔案";
                dialog.InitialDirectory = ".\\";
                dialog.Filter = "所有檔案 (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(dialog.FileName);
                    this.txt_Path.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Validator_Click(object sender, EventArgs e)
        {

        }
        private void UC_Validator_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.txt_Path.Text = filePaths[0];
        }

        private void UC_Validator_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;//调用DragDrop事件 
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
