namespace LVBTool
{
    partial class LVBTool
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_main = new System.Windows.Forms.TabControl();
            this.tp_SQL = new System.Windows.Forms.TabPage();
            this.tp1_tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tp_validator = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uC_SQLTool1 = new UserControlTools.UC_SQLTool();
            this.uC_Validator1 = new UserControlTools.UC.UC_Validator();
            this.tb_main.SuspendLayout();
            this.tp_SQL.SuspendLayout();
            this.tp1_tlp_main.SuspendLayout();
            this.tp_validator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.tp_SQL);
            this.tb_main.Controls.Add(this.tp_validator);
            this.tb_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_main.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_main.Location = new System.Drawing.Point(0, 0);
            this.tb_main.Name = "tb_main";
            this.tb_main.SelectedIndex = 0;
            this.tb_main.Size = new System.Drawing.Size(993, 597);
            this.tb_main.TabIndex = 0;
            // 
            // tp_SQL
            // 
            this.tp_SQL.BackColor = System.Drawing.Color.Gainsboro;
            this.tp_SQL.Controls.Add(this.tp1_tlp_main);
            this.tp_SQL.Location = new System.Drawing.Point(4, 30);
            this.tp_SQL.Name = "tp_SQL";
            this.tp_SQL.Padding = new System.Windows.Forms.Padding(3);
            this.tp_SQL.Size = new System.Drawing.Size(985, 563);
            this.tp_SQL.TabIndex = 0;
            this.tp_SQL.Text = "SQL相關";
            // 
            // tp1_tlp_main
            // 
            this.tp1_tlp_main.ColumnCount = 1;
            this.tp1_tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tp1_tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tp1_tlp_main.Controls.Add(this.uC_SQLTool1, 0, 0);
            this.tp1_tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp1_tlp_main.Location = new System.Drawing.Point(3, 3);
            this.tp1_tlp_main.Name = "tp1_tlp_main";
            this.tp1_tlp_main.RowCount = 1;
            this.tp1_tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tp1_tlp_main.Size = new System.Drawing.Size(979, 557);
            this.tp1_tlp_main.TabIndex = 0;
            // 
            // tp_validator
            // 
            this.tp_validator.BackColor = System.Drawing.Color.Gainsboro;
            this.tp_validator.Controls.Add(this.tableLayoutPanel1);
            this.tp_validator.Location = new System.Drawing.Point(4, 30);
            this.tp_validator.Name = "tp_validator";
            this.tp_validator.Padding = new System.Windows.Forms.Padding(3);
            this.tp_validator.Size = new System.Drawing.Size(985, 563);
            this.tp_validator.TabIndex = 1;
            this.tp_validator.Text = "驗證工具";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uC_Validator1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uC_SQLTool1
            // 
            this.uC_SQLTool1.Location = new System.Drawing.Point(5, 5);
            this.uC_SQLTool1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_SQLTool1.Name = "uC_SQLTool1";
            this.uC_SQLTool1.Size = new System.Drawing.Size(969, 547);
            this.uC_SQLTool1.TabIndex = 0;
            // 
            // uC_Validator1
            // 
            this.uC_Validator1.AllowDrop = true;
            this.uC_Validator1.Location = new System.Drawing.Point(5, 5);
            this.uC_Validator1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Validator1.Name = "uC_Validator1";
            this.uC_Validator1.Size = new System.Drawing.Size(969, 547);
            this.uC_Validator1.TabIndex = 0;
            // 
            // LVBTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 597);
            this.Controls.Add(this.tb_main);
            this.Name = "LVBTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LVBTool";
            this.tb_main.ResumeLayout(false);
            this.tp_SQL.ResumeLayout(false);
            this.tp1_tlp_main.ResumeLayout(false);
            this.tp_validator.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_main;
        private System.Windows.Forms.TabPage tp_SQL;
        private System.Windows.Forms.TabPage tp_validator;
        private System.Windows.Forms.TableLayoutPanel tp1_tlp_main;
        private UserControlTools.UC_SQLTool uC_SQLTool1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControlTools.UC.UC_Validator uC_Validator1;
    }
}

