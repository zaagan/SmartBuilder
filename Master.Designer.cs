namespace SmartBuilder
{
    partial class Master
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLeftContainer = new System.Windows.Forms.Panel();
            this.contentSwiper = new SmartBuilder.Controls.TileController();
            this.ctrlFastNote = new SmartBuilder.Controls.AdonaiFastNote();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Smart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(135, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Builder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLeftContainer
            // 
            this.pnlLeftContainer.Location = new System.Drawing.Point(-383, 52);
            this.pnlLeftContainer.Name = "pnlLeftContainer";
            this.pnlLeftContainer.Size = new System.Drawing.Size(382, 516);
            this.pnlLeftContainer.TabIndex = 5;
            // 
            // contentSwiper
            // 
            this.contentSwiper.ActiveColor = System.Drawing.Color.CornflowerBlue;
            this.contentSwiper.AdonaiHiddenTitle = "Builder";
            this.contentSwiper.AdonaiShownTitle = "Utilities";
            this.contentSwiper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contentSwiper.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentSwiper.IconType = FontAwesomeIcons.IconType.Exchange;
            this.contentSwiper.InactiveColor = System.Drawing.Color.DimGray;
            this.contentSwiper.Location = new System.Drawing.Point(248, 15);
            this.contentSwiper.MinimumSize = new System.Drawing.Size(155, 28);
            this.contentSwiper.Name = "contentSwiper";
            this.contentSwiper.Size = new System.Drawing.Size(155, 28);
            this.contentSwiper.TabIndex = 4;
            // 
            // ctrlFastNote
            // 
            this.ctrlFastNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlFastNote.ConnectionString = "Data Source=;Initial Catalog=;User Id=;Password=;";
            this.ctrlFastNote.DatabaseIndex = -1;
            this.ctrlFastNote.DatabaseName = "";
            this.ctrlFastNote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFastNote.Location = new System.Drawing.Point(0, 52);
            this.ctrlFastNote.MinimumSize = new System.Drawing.Size(380, 516);
            this.ctrlFastNote.Name = "ctrlFastNote";
            this.ctrlFastNote.Password = "";
            this.ctrlFastNote.ServerName = "";
            this.ctrlFastNote.Size = new System.Drawing.Size(409, 516);
            this.ctrlFastNote.TabIndex = 0;
            this.ctrlFastNote.UserName = "";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(409, 568);
            this.Controls.Add(this.pnlLeftContainer);
            this.Controls.Add(this.contentSwiper);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlFastNote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(398, 607);
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartBuilder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmartBuilder.Controls.AdonaiFastNote ctrlFastNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.TileController contentSwiper;
        private System.Windows.Forms.Panel pnlLeftContainer;
    }
}

