namespace SmartBuilder.Controls
{
    partial class TileController
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
            this.btnTransit = new FontAwesomeIcons.IconButton();
            this.titleControl1 = new SmartBuilder.Controls.TitleControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransit
            // 
            this.btnTransit.ActiveColor = System.Drawing.Color.CornflowerBlue;
            this.btnTransit.BackColor = System.Drawing.Color.Transparent;
            this.btnTransit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTransit.IconType = FontAwesomeIcons.IconType.Joomla;
            this.btnTransit.InActiveColor = System.Drawing.Color.DimGray;
            this.btnTransit.Location = new System.Drawing.Point(117, 0);
            this.btnTransit.Name = "btnTransit";
            this.btnTransit.Size = new System.Drawing.Size(38, 28);
            this.btnTransit.TabIndex = 0;
            this.btnTransit.TabStop = false;
            this.btnTransit.ToolTipText = null;
            this.btnTransit.Click += new System.EventHandler(this.btnTransit_Click);
            // 
            // titleControl1
            // 
            this.titleControl1.AdonaiHiddenTitle = "Second";
            this.titleControl1.AdonaiShownTitle = "First";
            this.titleControl1.AutoSize = true;
            this.titleControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleControl1.Location = new System.Drawing.Point(0, 0);
            this.titleControl1.MinimumSize = new System.Drawing.Size(117, 28);
            this.titleControl1.Name = "titleControl1";
            this.titleControl1.Size = new System.Drawing.Size(117, 28);
            this.titleControl1.TabIndex = 1;
            // 
            // TileController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleControl1);
            this.Controls.Add(this.btnTransit);
            this.MinimumSize = new System.Drawing.Size(155, 28);
            this.Name = "TileController";
            this.Size = new System.Drawing.Size(155, 28);
            ((System.ComponentModel.ISupportInitialize)(this.btnTransit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public FontAwesomeIcons.IconButton btnTransit;
        public TitleControl titleControl1;
    }
}
