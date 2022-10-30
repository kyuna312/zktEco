
namespace OdooZK9500
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlStage = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.lblHeader.Location = new System.Drawing.Point(-1, -5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(170, 37);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Odoo ZTK";
            // 
            // pnlStage
            // 
            this.pnlStage.Location = new System.Drawing.Point(6, 35);
            this.pnlStage.Name = "pnlStage";
            this.pnlStage.Size = new System.Drawing.Size(548, 327);
            this.pnlStage.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar.AutoSize = true;
            this.statusBar.Location = new System.Drawing.Point(1, 365);
            this.statusBar.MaximumSize = new System.Drawing.Size(550, 90);
            this.statusBar.MinimumSize = new System.Drawing.Size(550, 80);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(550, 80);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "label1";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pnlStage);
            this.Controls.Add(this.lblHeader);
            this.Name = "Master";
            this.Text = "Odoo ZTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlStage;
        private System.Windows.Forms.Label statusBar;
    }
}

