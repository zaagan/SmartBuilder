using System.Windows.Forms;

namespace SmartBuilder.ToolSet.Controls
{
    partial class SQLFormatter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLFormatter));
            this.inputsql = new TextBox();
            this.cmbdatabases = new System.Windows.Forms.ComboBox();
            this.btnFormatSQL = new System.Windows.Forms.Button();
            this.btnFormatSqlToHtml = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFormatSQLInRTF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCtrlStage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outputsql = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tlpStage = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbCtrlStage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpStage.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputsql
            // 
            this.inputsql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsql.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputsql.Location = new System.Drawing.Point(3, 3);
            this.inputsql.Multiline = true;
            this.inputsql.Name = "inputsql";
            this.inputsql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputsql.Size = new System.Drawing.Size(296, 205);
            this.inputsql.TabIndex = 2;
            this.inputsql.Text = resources.GetString("inputsql.Text");
            // 
            // cmbdatabases
            // 
            this.cmbdatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdatabases.FormattingEnabled = true;
            this.cmbdatabases.Items.AddRange(new object[] {
            "SQL Server",
            "Oracle",
            "DB2",
            "MySQL",
            "MS Access"});
            this.cmbdatabases.Location = new System.Drawing.Point(4, 3);
            this.cmbdatabases.Name = "cmbdatabases";
            this.cmbdatabases.Size = new System.Drawing.Size(124, 21);
            this.cmbdatabases.TabIndex = 8;
            // 
            // btnFormatSQL
            // 
            this.btnFormatSQL.Location = new System.Drawing.Point(3, 3);
            this.btnFormatSQL.Name = "btnFormatSQL";
            this.btnFormatSQL.Size = new System.Drawing.Size(91, 33);
            this.btnFormatSQL.TabIndex = 9;
            this.btnFormatSQL.Text = "Format SQL";
            this.btnFormatSQL.UseVisualStyleBackColor = true;
            this.btnFormatSQL.Click += new System.EventHandler(this.btnFormatSQL_Click);
            // 
            // btnFormatSqlToHtml
            // 
            this.btnFormatSqlToHtml.Location = new System.Drawing.Point(100, 3);
            this.btnFormatSqlToHtml.Name = "btnFormatSqlToHtml";
            this.btnFormatSqlToHtml.Size = new System.Drawing.Size(124, 33);
            this.btnFormatSqlToHtml.TabIndex = 10;
            this.btnFormatSqlToHtml.Text = "Format SQL In Html";
            this.btnFormatSqlToHtml.UseVisualStyleBackColor = true;
            this.btnFormatSqlToHtml.Click += new System.EventHandler(this.btnFormatSqlToHtml_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnFormatSQL);
            this.flowLayoutPanel1.Controls.Add(this.btnFormatSqlToHtml);
            this.flowLayoutPanel1.Controls.Add(this.btnFormatSQLInRTF);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 214);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 41);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnFormatSQLInRTF
            // 
            this.btnFormatSQLInRTF.Location = new System.Drawing.Point(3, 42);
            this.btnFormatSQLInRTF.Name = "btnFormatSQLInRTF";
            this.btnFormatSQLInRTF.Size = new System.Drawing.Size(118, 33);
            this.btnFormatSQLInRTF.TabIndex = 12;
            this.btnFormatSQLInRTF.Text = "Format SQL In RTF";
            this.btnFormatSQLInRTF.UseVisualStyleBackColor = true;
            this.btnFormatSQLInRTF.Click += new System.EventHandler(this.btnFormatSQLInRTF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear Screen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbCtrlStage
            // 
            this.tbCtrlStage.Controls.Add(this.tabPage1);
            this.tbCtrlStage.Controls.Add(this.tabPage2);
            this.tbCtrlStage.Controls.Add(this.tabPage3);
            this.tbCtrlStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlStage.Location = new System.Drawing.Point(3, 261);
            this.tbCtrlStage.Name = "tbCtrlStage";
            this.tbCtrlStage.SelectedIndex = 0;
            this.tbCtrlStage.Size = new System.Drawing.Size(296, 206);
            this.tbCtrlStage.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outputsql);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(288, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formatted SQL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outputsql
            // 
            this.outputsql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputsql.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputsql.Location = new System.Drawing.Point(3, 3);
            this.outputsql.Multiline = true;
            this.outputsql.Name = "outputsql";
            this.outputsql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputsql.Size = new System.Drawing.Size(282, 174);
            this.outputsql.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(298, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Formatted SQL In Html";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 22);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(292, 175);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(298, 181);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Formatted SQL In RTF";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(292, 175);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tlpStage
            // 
            this.tlpStage.ColumnCount = 1;
            this.tlpStage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStage.Controls.Add(this.inputsql, 0, 0);
            this.tlpStage.Controls.Add(this.tbCtrlStage, 0, 2);
            this.tlpStage.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tlpStage.Location = new System.Drawing.Point(4, 30);
            this.tlpStage.Name = "tlpStage";
            this.tlpStage.RowCount = 3;
            this.tlpStage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpStage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpStage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpStage.Size = new System.Drawing.Size(302, 470);
            this.tlpStage.TabIndex = 13;
            // 
            // SQLFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpStage);
            this.Controls.Add(this.cmbdatabases);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SQLFormatter";
            this.Size = new System.Drawing.Size(306, 503);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tbCtrlStage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpStage.ResumeLayout(false);
            this.tlpStage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox inputsql;
        private System.Windows.Forms.ComboBox cmbdatabases;
        private System.Windows.Forms.Button btnFormatSQL;
        private System.Windows.Forms.Button btnFormatSqlToHtml;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFormatSQLInRTF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tbCtrlStage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox outputsql;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tlpStage;
    }
}
