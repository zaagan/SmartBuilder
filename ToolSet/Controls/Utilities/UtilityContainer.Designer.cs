namespace SmartBuilder.ToolSet.Controls
{
    partial class UtilityContainer
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
            this.spcStage = new System.Windows.Forms.SplitContainer();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.spcPlayGround = new System.Windows.Forms.SplitContainer();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcStage)).BeginInit();
            this.spcStage.Panel1.SuspendLayout();
            this.spcStage.Panel2.SuspendLayout();
            this.spcStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPlayGround)).BeginInit();
            this.spcPlayGround.Panel1.SuspendLayout();
            this.spcPlayGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcStage
            // 
            this.spcStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcStage.IsSplitterFixed = true;
            this.spcStage.Location = new System.Drawing.Point(0, 0);
            this.spcStage.Name = "spcStage";
            // 
            // spcStage.Panel1
            // 
            this.spcStage.Panel1.Controls.Add(this.flpMenu);
            // 
            // spcStage.Panel2
            // 
            this.spcStage.Panel2.Controls.Add(this.spcPlayGround);
            this.spcStage.Size = new System.Drawing.Size(380, 516);
            this.spcStage.SplitterDistance = 73;
            this.spcStage.SplitterWidth = 1;
            this.spcStage.TabIndex = 0;
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(73, 516);
            this.flpMenu.TabIndex = 0;
            // 
            // spcPlayGround
            // 
            this.spcPlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPlayGround.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcPlayGround.IsSplitterFixed = true;
            this.spcPlayGround.Location = new System.Drawing.Point(0, 0);
            this.spcPlayGround.Name = "spcPlayGround";
            this.spcPlayGround.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcPlayGround.Panel1
            // 
            this.spcPlayGround.Panel1.BackColor = System.Drawing.Color.White;
            this.spcPlayGround.Panel1.Controls.Add(this.lblHeader);
            this.spcPlayGround.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.spcPlayGround.Size = new System.Drawing.Size(306, 516);
            this.spcPlayGround.SplitterDistance = 38;
            this.spcPlayGround.SplitterWidth = 1;
            this.spcPlayGround.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(7, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(91, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "MenuName";
            // 
            // UtilityContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcStage);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(380, 516);
            this.Name = "UtilityContainer";
            this.Size = new System.Drawing.Size(380, 516);
            this.spcStage.Panel1.ResumeLayout(false);
            this.spcStage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcStage)).EndInit();
            this.spcStage.ResumeLayout(false);
            this.spcPlayGround.Panel1.ResumeLayout(false);
            this.spcPlayGround.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPlayGround)).EndInit();
            this.spcPlayGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcStage;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.SplitContainer spcPlayGround;
        private System.Windows.Forms.Label lblHeader;
    }
}
