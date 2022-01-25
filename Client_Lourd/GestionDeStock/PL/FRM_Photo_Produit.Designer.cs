
namespace GestionDeStock.PL
{
    partial class FRM_Photo_Produit
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProduitImage = new System.Windows.Forms.PictureBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.ProduitNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(598, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 520);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 519);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 519);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 1);
            this.panel3.TabIndex = 6;
            // 
            // ProduitImage
            // 
            this.ProduitImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduitImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProduitImage.Location = new System.Drawing.Point(12, 51);
            this.ProduitImage.Name = "ProduitImage";
            this.ProduitImage.Size = new System.Drawing.Size(575, 457);
            this.ProduitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProduitImage.TabIndex = 7;
            this.ProduitImage.TabStop = false;
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(559, 1);
            this.btnquitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(39, 35);
            this.btnquitter.TabIndex = 41;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // ProduitNom
            // 
            this.ProduitNom.AutoSize = true;
            this.ProduitNom.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProduitNom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProduitNom.Location = new System.Drawing.Point(12, 12);
            this.ProduitNom.Name = "ProduitNom";
            this.ProduitNom.Size = new System.Drawing.Size(88, 36);
            this.ProduitNom.TabIndex = 42;
            this.ProduitNom.Text = "label1";
            // 
            // FRM_Photo_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(599, 520);
            this.Controls.Add(this.ProduitNom);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.ProduitImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Photo_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Photo_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.ProduitImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.PictureBox ProduitImage;
        public System.Windows.Forms.Label ProduitNom;
    }
}