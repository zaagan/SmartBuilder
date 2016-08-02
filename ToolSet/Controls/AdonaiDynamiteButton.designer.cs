namespace SmartBuilder.ToolSet.Controls
{
    partial class AdonaiDynamiteButton
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
            this.adonaiPanel1 = new SmartBuilder.ToolSet.Controls.AdonaiPanel();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.icbItem = new FontAwesomeIcons.IconButton();
            this.adonaiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbItem)).BeginInit();
            this.SuspendLayout();
            // 
            // adonaiPanel1
            // 
            this.adonaiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.adonaiPanel1.Controls.Add(this.lblHeaderName);
            this.adonaiPanel1.Controls.Add(this.icbItem);
            this.adonaiPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adonaiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adonaiPanel1.Location = new System.Drawing.Point(0, 0);
            this.adonaiPanel1.Name = "adonaiPanel1";
            this.adonaiPanel1.Size = new System.Drawing.Size(68, 69);
            this.adonaiPanel1.TabIndex = 0;
            this.adonaiPanel1.Click += new System.EventHandler(this.lblHeaderName_Click);
            this.adonaiPanel1.MouseLeave += new System.EventHandler(this.adonaiPanel1_MouseLeave);
            this.adonaiPanel1.MouseHover += new System.EventHandler(this.adonaiPanel1_MouseHover);
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderName.AutoEllipsis = true;
            this.lblHeaderName.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHeaderName.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.lblHeaderName.Location = new System.Drawing.Point(6, 42);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(57, 23);
            this.lblHeaderName.TabIndex = 366;
            this.lblHeaderName.Text = "Type Header";
            this.lblHeaderName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeaderName.Click += new System.EventHandler(this.lblHeaderName_Click);
            this.lblHeaderName.MouseLeave += new System.EventHandler(this.adonaiPanel1_MouseLeave);
            this.lblHeaderName.MouseHover += new System.EventHandler(this.adonaiPanel1_MouseHover);
            // 
            // icbItem
            // 
            this.icbItem.ActiveColor = System.Drawing.Color.Orange;
            this.icbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icbItem.BackColor = System.Drawing.Color.Transparent;
            this.icbItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbItem.IconType = FontAwesomeIcons.IconType.Ge;
            this.icbItem.InActiveColor = System.Drawing.Color.DimGray;
            this.icbItem.Location = new System.Drawing.Point(16, 5);
            this.icbItem.Name = "icbItem";
            this.icbItem.Size = new System.Drawing.Size(38, 34);
            this.icbItem.TabIndex = 329;
            this.icbItem.TabStop = false;
            this.icbItem.ToolTipText = null;
            this.icbItem.Click += new System.EventHandler(this.lblHeaderName_Click);
            this.icbItem.MouseLeave += new System.EventHandler(this.adonaiPanel1_MouseLeave);
            this.icbItem.MouseHover += new System.EventHandler(this.adonaiPanel1_MouseHover);
            // 
            // AdonaiDynamiteButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.adonaiPanel1);
            this.MinimumSize = new System.Drawing.Size(68, 69);
            this.Name = "AdonaiDynamiteButton";
            this.Size = new System.Drawing.Size(68, 69);
            this.adonaiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdonaiPanel adonaiPanel1;
        private FontAwesomeIcons.IconButton icbItem;
        public System.Windows.Forms.Label lblHeaderName;
    }
}
