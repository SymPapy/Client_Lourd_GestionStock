
namespace GestionDeStock.PL
{
    partial class USER_Liste_Categorie
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnajouterclient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.dvgcategorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnimprimertout = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajouterclient
            // 
            this.btnajouterclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouterclient.FlatAppearance.BorderSize = 0;
            this.btnajouterclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterclient.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouterclient.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouterclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterclient.Location = new System.Drawing.Point(20, 12);
            this.btnajouterclient.Name = "btnajouterclient";
            this.btnajouterclient.Size = new System.Drawing.Size(245, 60);
            this.btnajouterclient.TabIndex = 11;
            this.btnajouterclient.Text = "Ajouter";
            this.btnajouterclient.UseVisualStyleBackColor = false;
            this.btnajouterclient.Click += new System.EventHandler(this.btnajouterclient_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(460, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 3);
            this.panel3.TabIndex = 18;
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtrecherche.Location = new System.Drawing.Point(460, 25);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(451, 33);
            this.txtrecherche.TabIndex = 17;
            this.txtrecherche.Text = "Rechercher";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.Enter += new System.EventHandler(this.txtrecherche_Enter);
            // 
            // dvgcategorie
            // 
            this.dvgcategorie.AllowUserToAddRows = false;
            this.dvgcategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgcategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgcategorie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgcategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column5,
            this.Modifier,
            this.Supprimer});
            this.dvgcategorie.EnableHeadersVisualStyles = false;
            this.dvgcategorie.Location = new System.Drawing.Point(3, 88);
            this.dvgcategorie.Name = "dvgcategorie";
            this.dvgcategorie.RowHeadersVisible = false;
            this.dvgcategorie.RowHeadersWidth = 51;
            this.dvgcategorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgcategorie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgcategorie.Size = new System.Drawing.Size(1131, 534);
            this.dvgcategorie.TabIndex = 19;
            this.dvgcategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcategorie_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nom Catégorie";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Modifier
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle3;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // btnimprimertout
            // 
            this.btnimprimertout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnimprimertout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnimprimertout.FlatAppearance.BorderSize = 0;
            this.btnimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimertout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimertout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimertout.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.btnimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimertout.Location = new System.Drawing.Point(20, 641);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(308, 60);
            this.btnimprimertout.TabIndex = 23;
            this.btnimprimertout.Text = "Tout imprimer";
            this.btnimprimertout.UseVisualStyleBackColor = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnexcel.FlatAppearance.BorderSize = 0;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexcel.Image = global::GestionDeStock.Properties.Resources.Excel_icon;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(807, 641);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(308, 60);
            this.btnexcel.TabIndex = 24;
            this.btnexcel.Text = "Sauvegarder";
            this.btnexcel.UseVisualStyleBackColor = false;
            // 
            // USER_Liste_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnimprimertout);
            this.Controls.Add(this.dvgcategorie);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnajouterclient);
            this.Name = "USER_Liste_Categorie";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajouterclient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.DataGridView dvgcategorie;
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
