namespace UserControlTools.UC
{
    partial class UC_Validator
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Validator = new System.Windows.Forms.Button();
            this.btn_loadFile = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 5;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.518105F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.59052F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.659212F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58442F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.87712F));
            this.tlp_main.Controls.Add(this.txt_Path, 1, 0);
            this.tlp_main.Controls.Add(this.label1, 0, 0);
            this.tlp_main.Controls.Add(this.btn_Validator, 3, 0);
            this.tlp_main.Controls.Add(this.btn_loadFile, 2, 0);
            this.tlp_main.Controls.Add(this.txt_result, 0, 1);
            this.tlp_main.Controls.Add(this.label2, 4, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 2;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42953F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.57047F));
            this.tlp_main.Size = new System.Drawing.Size(1001, 596);
            this.tlp_main.TabIndex = 0;
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Path.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Path.Location = new System.Drawing.Point(98, 28);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(469, 29);
            this.txt_Path.TabIndex = 2;
            this.txt_Path.Text = "SQLContent";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "路徑";
            // 
            // btn_Validator
            // 
            this.btn_Validator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Validator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Validator.Location = new System.Drawing.Point(619, 19);
            this.btn_Validator.Name = "btn_Validator";
            this.btn_Validator.Size = new System.Drawing.Size(58, 46);
            this.btn_Validator.TabIndex = 4;
            this.btn_Validator.Text = "驗證";
            this.btn_Validator.UseVisualStyleBackColor = true;
            this.btn_Validator.Click += new System.EventHandler(this.btn_Validator_Click);
            // 
            // btn_loadFile
            // 
            this.btn_loadFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_loadFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_loadFile.Location = new System.Drawing.Point(573, 26);
            this.btn_loadFile.Name = "btn_loadFile";
            this.btn_loadFile.Size = new System.Drawing.Size(38, 33);
            this.btn_loadFile.TabIndex = 4;
            this.btn_loadFile.Text = "...";
            this.btn_loadFile.UseVisualStyleBackColor = true;
            this.btn_loadFile.Click += new System.EventHandler(this.btn_loadFile_Click);
            // 
            // txt_result
            // 
            this.tlp_main.SetColumnSpan(this.txt_result, 3);
            this.txt_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_result.Location = new System.Drawing.Point(3, 88);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(610, 505);
            this.txt_result.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(774, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "可直接將檔案拖拉至畫面";
            // 
            // UC_Validator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_main);
            this.Name = "UC_Validator";
            this.Size = new System.Drawing.Size(1001, 596);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UC_Validator_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UC_Validator_DragEnter);
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Validator;
        private System.Windows.Forms.Button btn_loadFile;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label2;
    }
}
