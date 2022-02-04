
namespace GestionDeStock.PL
{
    partial class FRM_Produit_Commande
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
            this.grpproduit = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.textremise = new System.Windows.Forms.TextBox();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblquantite = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblprix = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.grpproduit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpproduit
            // 
            this.grpproduit.Controls.Add(this.label9);
            this.grpproduit.Controls.Add(this.texttotal);
            this.grpproduit.Controls.Add(this.textremise);
            this.grpproduit.Controls.Add(this.txtquantite);
            this.grpproduit.Controls.Add(this.label2);
            this.grpproduit.Controls.Add(this.label1);
            this.grpproduit.Controls.Add(this.lblquantite);
            this.grpproduit.Controls.Add(this.groupBox2);
            this.grpproduit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpproduit.Location = new System.Drawing.Point(16, 12);
            this.grpproduit.Name = "grpproduit";
            this.grpproduit.Size = new System.Drawing.Size(507, 430);
            this.grpproduit.TabIndex = 0;
            this.grpproduit.TabStop = false;
            this.grpproduit.Text = "Produit en vente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(447, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "%";
            // 
            // texttotal
            // 
            this.texttotal.Enabled = false;
            this.texttotal.Font = new System.Drawing.Font("Calibri", 14F);
            this.texttotal.Location = new System.Drawing.Point(273, 357);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(168, 30);
            this.texttotal.TabIndex = 36;
            // 
            // textremise
            // 
            this.textremise.Font = new System.Drawing.Font("Calibri", 14F);
            this.textremise.Location = new System.Drawing.Point(273, 218);
            this.textremise.Name = "textremise";
            this.textremise.Size = new System.Drawing.Size(168, 30);
            this.textremise.TabIndex = 35;
            this.textremise.TextChanged += new System.EventHandler(this.textremise_TextChanged);
            this.textremise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textremise_KeyPress);
            // 
            // txtquantite
            // 
            this.txtquantite.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtquantite.Location = new System.Drawing.Point(273, 84);
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(168, 30);
            this.txtquantite.TabIndex = 34;
            this.txtquantite.TextChanged += new System.EventHandler(this.txtquantite_TextChanged);
            this.txtquantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantite_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(269, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "-- Total ------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(269, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "-- Remise ---------------";
            // 
            // lblquantite
            // 
            this.lblquantite.AutoSize = true;
            this.lblquantite.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblquantite.Location = new System.Drawing.Point(269, 46);
            this.lblquantite.Name = "lblquantite";
            this.lblquantite.Size = new System.Drawing.Size(178, 23);
            this.lblquantite.TabIndex = 28;
            this.lblquantite.Text = "-- Quantité -------------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblprix);
            this.groupBox2.Controls.Add(this.lblstock);
            this.groupBox2.Controls.Add(this.lblnom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(18, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 366);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détail du Produit";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblid.Font = new System.Drawing.Font("Calibri", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(54, 51);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 21);
            this.lblid.TabIndex = 39;
            this.lblid.Text = "ll";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(5, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Id :";
            // 
            // lblprix
            // 
            this.lblprix.AutoSize = true;
            this.lblprix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblprix.Font = new System.Drawing.Font("Calibri", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblprix.ForeColor = System.Drawing.Color.White;
            this.lblprix.Location = new System.Drawing.Point(73, 253);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(23, 21);
            this.lblprix.TabIndex = 37;
            this.lblprix.Text = "lp";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblstock.Font = new System.Drawing.Font("Calibri", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblstock.ForeColor = System.Drawing.Color.White;
            this.lblstock.Location = new System.Drawing.Point(74, 179);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(21, 21);
            this.lblstock.TabIndex = 36;
            this.lblstock.Text = "ls";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblnom.Font = new System.Drawing.Font("Calibri", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(53, 109);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(23, 21);
            this.lblnom.TabIndex = 35;
            this.lblnom.Text = "ln";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(2, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nom :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnregistrer.Location = new System.Drawing.Point(90, 448);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(356, 47);
            this.btnEnregistrer.TabIndex = 28;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FRM_Produit_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(535, 505);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.grpproduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Produit_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.grpproduit.ResumeLayout(false);
            this.grpproduit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblquantite;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.TextBox texttotal;
        public System.Windows.Forms.TextBox textremise;
        public System.Windows.Forms.TextBox txtquantite;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblprix;
        public System.Windows.Forms.Label lblstock;
        public System.Windows.Forms.Label lblnom;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox grpproduit;
    }
}