namespace SmartBuilder.Controls
{
    partial class ctrlMultiTableSelector
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
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.chkIsProviderRequred = new System.Windows.Forms.CheckBox();
            this.chkIsController = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chklsSerializable = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkList
            // 
            this.chkList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkList.FormattingEnabled = true;
            this.chkList.Location = new System.Drawing.Point(0, 0);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(299, 140);
            this.chkList.TabIndex = 1;
            // 
            // chkIsProviderRequred
            // 
            this.chkIsProviderRequred.AutoSize = true;
            this.chkIsProviderRequred.Checked = true;
            this.chkIsProviderRequred.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsProviderRequred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsProviderRequred.Location = new System.Drawing.Point(145, 7);
            this.chkIsProviderRequred.Name = "chkIsProviderRequred";
            this.chkIsProviderRequred.Size = new System.Drawing.Size(126, 17);
            this.chkIsProviderRequred.TabIndex = 14;
            this.chkIsProviderRequred.Text = "Is Provider Requred";
            this.chkIsProviderRequred.UseVisualStyleBackColor = true;
            // 
            // chkIsController
            // 
            this.chkIsController.AutoSize = true;
            this.chkIsController.Checked = true;
            this.chkIsController.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsController.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsController.Location = new System.Drawing.Point(3, 7);
            this.chkIsController.Name = "chkIsController";
            this.chkIsController.Size = new System.Drawing.Size(136, 17);
            this.chkIsController.TabIndex = 13;
            this.chkIsController.Text = "Is Controller Requred";
            this.chkIsController.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(165, 49);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUncheckAll.Location = new System.Drawing.Point(84, 49);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnUncheckAll.TabIndex = 11;
            this.btnUncheckAll.Text = "Unchek All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAll.Location = new System.Drawing.Point(3, 49);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 10;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chklsSerializable);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.chkIsProviderRequred);
            this.panel1.Controls.Add(this.btnUncheckAll);
            this.panel1.Controls.Add(this.chkIsController);
            this.panel1.Controls.Add(this.btnCheckAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 75);
            this.panel1.TabIndex = 15;
            // 
            // chklsSerializable
            // 
            this.chklsSerializable.AutoSize = true;
            this.chklsSerializable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chklsSerializable.Location = new System.Drawing.Point(3, 30);
            this.chklsSerializable.Name = "chklsSerializable";
            this.chklsSerializable.Size = new System.Drawing.Size(95, 17);
            this.chklsSerializable.TabIndex = 15;
            this.chklsSerializable.Text = "Is Serializable";
            this.chklsSerializable.UseVisualStyleBackColor = true;
            // 
            // ctrlMultiTableSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlMultiTableSelector";
            this.Size = new System.Drawing.Size(299, 221);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkList;
        private System.Windows.Forms.CheckBox chkIsProviderRequred;
        private System.Windows.Forms.CheckBox chkIsController;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chklsSerializable;
    }
}
