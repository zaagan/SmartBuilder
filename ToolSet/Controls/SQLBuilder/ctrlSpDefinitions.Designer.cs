namespace SmartBuilder.Controls
{
    partial class ctrlSpDefinitions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOutputType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenrate = new System.Windows.Forms.Button();
            this.tbxExcludePrefix = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbtn2);
            this.groupBox1.Controls.Add(this.rbtn1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxOutputType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnGenrate);
            this.groupBox1.Controls.Add(this.tbxExcludePrefix);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.lblTableName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Checked = true;
            this.rbtn2.Location = new System.Drawing.Point(104, 166);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(162, 19);
            this.rbtn2.TabIndex = 65;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "SELECT [ColumnName,]...";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(10, 166);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(72, 19);
            this.rbtn1.TabIndex = 64;
            this.rbtn1.Text = "SELECT *";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Select Query Type for \'_lst\' and \'_sel\' procedures";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(7, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Example : \'tbl_\'";
            // 
            // cbxOutputType
            // 
            this.cbxOutputType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxOutputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutputType.FormattingEnabled = true;
            this.cbxOutputType.Items.AddRange(new object[] {
            "Export to FastNote",
            "Execute Script"});
            this.cbxOutputType.Location = new System.Drawing.Point(92, 55);
            this.cbxOutputType.MaximumSize = new System.Drawing.Size(231, 0);
            this.cbxOutputType.Name = "cbxOutputType";
            this.cbxOutputType.Size = new System.Drawing.Size(201, 23);
            this.cbxOutputType.TabIndex = 61;
            this.cbxOutputType.SelectedIndexChanged += new System.EventHandler(this.cbxOutputType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "Output Type :";
            // 
            // btnGenrate
            // 
            this.btnGenrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenrate.Location = new System.Drawing.Point(202, 260);
            this.btnGenrate.Name = "btnGenrate";
            this.btnGenrate.Size = new System.Drawing.Size(91, 23);
            this.btnGenrate.TabIndex = 2;
            this.btnGenrate.Text = "Run";
            this.btnGenrate.UseVisualStyleBackColor = true;
            this.btnGenrate.Click += new System.EventHandler(this.btnGenrate_Click);
            // 
            // tbxExcludePrefix
            // 
            this.tbxExcludePrefix.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.tbxExcludePrefix.Location = new System.Drawing.Point(92, 104);
            this.tbxExcludePrefix.Name = "tbxExcludePrefix";
            this.tbxExcludePrefix.Size = new System.Drawing.Size(201, 23);
            this.tbxExcludePrefix.TabIndex = 1;
            this.tbxExcludePrefix.Text = "tbl_";
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtTableName.Location = new System.Drawing.Point(92, 25);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(201, 23);
            this.txtTableName.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblClassName.Location = new System.Drawing.Point(7, 87);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(229, 15);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "Exclude Prefix in stored procedure names :";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTableName.Location = new System.Drawing.Point(7, 28);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(74, 15);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label3.Location = new System.Drawing.Point(7, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Developer :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(95, 201);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(198, 23);
            this.txtUserName.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.Location = new System.Drawing.Point(7, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 68;
            this.label4.Text = "Description :";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(95, 231);
            this.txtReason.MaxLength = 29;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(198, 23);
            this.txtReason.TabIndex = 69;
            // 
            // ctrlSpDefinitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "ctrlSpDefinitions";
            this.Size = new System.Drawing.Size(302, 300);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenrate;
        private System.Windows.Forms.TextBox tbxExcludePrefix;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.ComboBox cbxOutputType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
    }
}
