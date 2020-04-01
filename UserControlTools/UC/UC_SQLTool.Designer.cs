namespace UserControlTools
{
    partial class UC_SQLTool
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_ori = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Var = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SQLToPG = new System.Windows.Forms.Button();
            this.btn_PGToSQL = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.txt_result, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ori, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_SQLToPG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_PGToSQL, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.56281F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.43719F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 597);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txt_result
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_result, 2);
            this.txt_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_result.Location = new System.Drawing.Point(519, 77);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_result.Size = new System.Drawing.Size(510, 517);
            this.txt_result.TabIndex = 2;
            // 
            // txt_ori
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_ori, 2);
            this.txt_ori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ori.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ori.Location = new System.Drawing.Point(3, 77);
            this.txt_ori.Multiline = true;
            this.txt_ori.Name = "txt_ori";
            this.txt_ori.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ori.Size = new System.Drawing.Size(510, 517);
            this.txt_ori.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.82716F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.17284F));
            this.tableLayoutPanel2.Controls.Add(this.txt_Var, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 68);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_Var
            // 
            this.txt_Var.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Var.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Var.Location = new System.Drawing.Point(113, 19);
            this.txt_Var.Name = "txt_Var";
            this.txt_Var.Size = new System.Drawing.Size(130, 29);
            this.txt_Var.TabIndex = 0;
            this.txt_Var.Text = "SQLContent";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "變數名稱";
            // 
            // btn_SQLToPG
            // 
            this.btn_SQLToPG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_SQLToPG.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SQLToPG.Location = new System.Drawing.Point(261, 14);
            this.btn_SQLToPG.Name = "btn_SQLToPG";
            this.btn_SQLToPG.Size = new System.Drawing.Size(126, 46);
            this.btn_SQLToPG.TabIndex = 1;
            this.btn_SQLToPG.Text = "SQL To C#";
            this.btn_SQLToPG.UseVisualStyleBackColor = true;
            this.btn_SQLToPG.Click += new System.EventHandler(this.btn_SQLToPG_Click);
            // 
            // btn_PGToSQL
            // 
            this.btn_PGToSQL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_PGToSQL.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PGToSQL.Location = new System.Drawing.Point(519, 14);
            this.btn_PGToSQL.Name = "btn_PGToSQL";
            this.btn_PGToSQL.Size = new System.Drawing.Size(126, 46);
            this.btn_PGToSQL.TabIndex = 1;
            this.btn_PGToSQL.Text = "C# To SQL";
            this.btn_PGToSQL.UseVisualStyleBackColor = true;
            this.btn_PGToSQL.Click += new System.EventHandler(this.btn_PGToSQL_Click);
            // 
            // UC_SQLTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_SQLTool";
            this.Size = new System.Drawing.Size(1032, 597);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_ori;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_Var;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SQLToPG;
        private System.Windows.Forms.Button btn_PGToSQL;
    }
}
