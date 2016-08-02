namespace SmartBuilder.Controls
{
    partial class ctrlTableInfo
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
            this.chklsSerializable = new System.Windows.Forms.CheckBox();
            this.chkIsProviderRequred = new System.Windows.Forms.CheckBox();
            this.chkIsController = new System.Windows.Forms.CheckBox();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.lblChooseType = new System.Windows.Forms.Label();
            this.chkIsNullableRequred = new System.Windows.Forms.CheckBox();
            this.btnGenrate = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDefaultNamespace = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tbxDefaultNamespace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chklsSerializable);
            this.groupBox1.Controls.Add(this.chkIsProviderRequred);
            this.groupBox1.Controls.Add(this.chkIsController);
            this.groupBox1.Controls.Add(this.ddlType);
            this.groupBox1.Controls.Add(this.lblChooseType);
            this.groupBox1.Controls.Add(this.chkIsNullableRequred);
            this.groupBox1.Controls.Add(this.btnGenrate);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.lblTableName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // chklsSerializable
            // 
            this.chklsSerializable.AutoSize = true;
            this.chklsSerializable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chklsSerializable.Location = new System.Drawing.Point(158, 167);
            this.chklsSerializable.Name = "chklsSerializable";
            this.chklsSerializable.Size = new System.Drawing.Size(95, 19);
            this.chklsSerializable.TabIndex = 9;
            this.chklsSerializable.Text = "Is Serializable";
            this.chklsSerializable.UseVisualStyleBackColor = true;
            // 
            // chkIsProviderRequred
            // 
            this.chkIsProviderRequred.AutoSize = true;
            this.chkIsProviderRequred.Checked = true;
            this.chkIsProviderRequred.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsProviderRequred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsProviderRequred.Location = new System.Drawing.Point(11, 167);
            this.chkIsProviderRequred.Name = "chkIsProviderRequred";
            this.chkIsProviderRequred.Size = new System.Drawing.Size(128, 19);
            this.chkIsProviderRequred.TabIndex = 8;
            this.chkIsProviderRequred.Text = "Is Provider Requred";
            this.chkIsProviderRequred.UseVisualStyleBackColor = true;
            // 
            // chkIsController
            // 
            this.chkIsController.AutoSize = true;
            this.chkIsController.Checked = true;
            this.chkIsController.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsController.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsController.Location = new System.Drawing.Point(158, 144);
            this.chkIsController.Name = "chkIsController";
            this.chkIsController.Size = new System.Drawing.Size(137, 19);
            this.chkIsController.TabIndex = 7;
            this.chkIsController.Text = "Is Controller Requred";
            this.chkIsController.UseVisualStyleBackColor = true;
            // 
            // ddlType
            // 
            this.ddlType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlType.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Location = new System.Drawing.Point(141, 27);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(201, 21);
            this.ddlType.TabIndex = 6;
            this.ddlType.SelectedIndexChanged += new System.EventHandler(this.ddlType_SelectedIndexChanged);
            // 
            // lblChooseType
            // 
            this.lblChooseType.AutoSize = true;
            this.lblChooseType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChooseType.Location = new System.Drawing.Point(7, 27);
            this.lblChooseType.Name = "lblChooseType";
            this.lblChooseType.Size = new System.Drawing.Size(90, 19);
            this.lblChooseType.TabIndex = 5;
            this.lblChooseType.Text = "Choose Type:";
            // 
            // chkIsNullableRequred
            // 
            this.chkIsNullableRequred.AutoSize = true;
            this.chkIsNullableRequred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsNullableRequred.Location = new System.Drawing.Point(11, 144);
            this.chkIsNullableRequred.Name = "chkIsNullableRequred";
            this.chkIsNullableRequred.Size = new System.Drawing.Size(128, 19);
            this.chkIsNullableRequred.TabIndex = 4;
            this.chkIsNullableRequred.Text = "Is Nullable Requred";
            this.chkIsNullableRequred.UseVisualStyleBackColor = true;
            // 
            // btnGenrate
            // 
            this.btnGenrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenrate.Location = new System.Drawing.Point(197, 192);
            this.btnGenrate.Name = "btnGenrate";
            this.btnGenrate.Size = new System.Drawing.Size(97, 23);
            this.btnGenrate.TabIndex = 2;
            this.btnGenrate.Text = "Build";
            this.btnGenrate.UseVisualStyleBackColor = true;
            this.btnGenrate.Click += new System.EventHandler(this.btnGenrate_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtClassName.Location = new System.Drawing.Point(141, 78);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(201, 23);
            this.txtClassName.TabIndex = 1;
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtTableName.Location = new System.Drawing.Point(141, 52);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(201, 23);
            this.txtTableName.TabIndex = 0;
            this.txtTableName.TextChanged += new System.EventHandler(this.txtTableName_TextChanged);
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClassName.Location = new System.Drawing.Point(7, 78);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(83, 19);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "Class Name:";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTableName.Location = new System.Drawing.Point(7, 52);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(82, 19);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Namespace:";
            // 
            // tbxDefaultNamespace
            // 
            this.tbxDefaultNamespace.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.tbxDefaultNamespace.Location = new System.Drawing.Point(141, 105);
            this.tbxDefaultNamespace.Name = "tbxDefaultNamespace";
            this.tbxDefaultNamespace.Size = new System.Drawing.Size(201, 23);
            this.tbxDefaultNamespace.TabIndex = 11;
            // 
            // ctrlTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "ctrlTableInfo";
            this.Size = new System.Drawing.Size(372, 223);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIsProviderRequred;
        private System.Windows.Forms.CheckBox chkIsController;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label lblChooseType;
        private System.Windows.Forms.CheckBox chkIsNullableRequred;
        private System.Windows.Forms.Button btnGenrate;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.CheckBox chklsSerializable;
        private System.Windows.Forms.TextBox tbxDefaultNamespace;
        private System.Windows.Forms.Label label1;
    }
}
