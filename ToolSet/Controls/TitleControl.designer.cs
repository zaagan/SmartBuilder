using System.Windows.Forms;

namespace SmartBuilder.Controls
{
    partial class TitleControl
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
            this.pnlHidden = new System.Windows.Forms.TableLayoutPanel();
            this.lblHidden = new System.Windows.Forms.Label();
            this.pnlShown = new System.Windows.Forms.TableLayoutPanel();
            this.lblShown = new System.Windows.Forms.Label();
            this.pnlHidden.SuspendLayout();
            this.pnlShown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHidden
            // 
            this.pnlHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHidden.BackColor = System.Drawing.Color.Transparent;
            this.pnlHidden.ColumnCount = 1;
            this.pnlHidden.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHidden.Controls.Add(this.lblHidden, 0, 0);
            this.pnlHidden.Location = new System.Drawing.Point(117, 0);
            this.pnlHidden.MinimumSize = new System.Drawing.Size(117, 28);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlHidden.RowCount = 1;
            this.pnlHidden.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHidden.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlHidden.Size = new System.Drawing.Size(117, 28);
            this.pnlHidden.TabIndex = 0;
            // 
            // lblHidden
            // 
            this.lblHidden.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHidden.Location = new System.Drawing.Point(49, 3);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(65, 21);
            this.lblHidden.TabIndex = 287;
            this.lblHidden.Text = "Second";
            // 
            // pnlShown
            // 
            this.pnlShown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShown.BackColor = System.Drawing.Color.Transparent;
            this.pnlShown.ColumnCount = 1;
            this.pnlShown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlShown.Controls.Add(this.lblShown, 0, 0);
            this.pnlShown.Location = new System.Drawing.Point(0, 0);
            this.pnlShown.MinimumSize = new System.Drawing.Size(117, 28);
            this.pnlShown.Name = "pnlShown";
            this.pnlShown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlShown.RowCount = 1;
            this.pnlShown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlShown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlShown.Size = new System.Drawing.Size(117, 28);
            this.pnlShown.TabIndex = 1;
            // 
            // lblShown
            // 
            this.lblShown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShown.AutoSize = true;
            this.lblShown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShown.Location = new System.Drawing.Point(73, 3);
            this.lblShown.Name = "lblShown";
            this.lblShown.Size = new System.Drawing.Size(41, 21);
            this.lblShown.TabIndex = 286;
            this.lblShown.Text = "First";
            // 
            // TitleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlHidden);
            this.Controls.Add(this.pnlShown);
            this.MinimumSize = new System.Drawing.Size(117, 28);
            this.Name = "TitleControl";
            this.Size = new System.Drawing.Size(318, 150);
            this.pnlHidden.ResumeLayout(false);
            this.pnlHidden.PerformLayout();
            this.pnlShown.ResumeLayout(false);
            this.pnlShown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlHidden;
        private System.Windows.Forms.TableLayoutPanel pnlShown;
        private Label lblShown;
        private Label lblHidden;

    }
}
