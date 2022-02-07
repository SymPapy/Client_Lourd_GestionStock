
namespace GestionDeStock.RAP
{
    partial class FRM_RAPPORTE
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
            this.RPAfficher = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPAfficher
            // 
            this.RPAfficher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPAfficher.Location = new System.Drawing.Point(0, 0);
            this.RPAfficher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RPAfficher.Name = "RPAfficher";
            this.RPAfficher.ServerReport.BearerToken = null;
            this.RPAfficher.Size = new System.Drawing.Size(1090, 695);
            this.RPAfficher.TabIndex = 0;
            // 
            // FRM_RAPPORTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 695);
            this.Controls.Add(this.RPAfficher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRM_RAPPORTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.FRM_RAPPORTE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RPAfficher;
    }
}