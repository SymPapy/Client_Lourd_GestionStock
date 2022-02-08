
namespace GestionDeStock.PL
{
    partial class USER_Utilisateurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvguser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsupprimerclient = new System.Windows.Forms.Button();
            this.btnmodifierclient = new System.Windows.Forms.Button();
            this.btnajouteclient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvguser)).BeginInit();
            this.SuspendLayout();
            // 
            // dvguser
            // 
            this.dvguser.AllowUserToAddRows = false;
            this.dvguser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvguser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvguser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvguser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvguser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvguser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvguser.EnableHeadersVisualStyles = false;
            this.dvguser.Location = new System.Drawing.Point(329, 20);
            this.dvguser.Margin = new System.Windows.Forms.Padding(4);
            this.dvguser.Name = "dvguser";
            this.dvguser.RowHeadersVisible = false;
            this.dvguser.RowHeadersWidth = 51;
            this.dvguser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvguser.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dvguser.Size = new System.Drawing.Size(468, 554);
            this.dvguser.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnsupprimerclient
            // 
            this.btnsupprimerclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsupprimerclient.FlatAppearance.BorderSize = 0;
            this.btnsupprimerclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimerclient.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimerclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimerclient.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnsupprimerclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerclient.Location = new System.Drawing.Point(18, 149);
            this.btnsupprimerclient.Margin = new System.Windows.Forms.Padding(4);
            this.btnsupprimerclient.Name = "btnsupprimerclient";
            this.btnsupprimerclient.Size = new System.Drawing.Size(265, 47);
            this.btnsupprimerclient.TabIndex = 4;
            this.btnsupprimerclient.Text = "Supprimer";
            this.btnsupprimerclient.UseVisualStyleBackColor = false;
            this.btnsupprimerclient.Click += new System.EventHandler(this.btnsupprimerclient_Click);
            // 
            // btnmodifierclient
            // 
            this.btnmodifierclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnmodifierclient.FlatAppearance.BorderSize = 0;
            this.btnmodifierclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifierclient.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifierclient.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnmodifierclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierclient.Location = new System.Drawing.Point(18, 83);
            this.btnmodifierclient.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodifierclient.Name = "btnmodifierclient";
            this.btnmodifierclient.Size = new System.Drawing.Size(265, 47);
            this.btnmodifierclient.TabIndex = 3;
            this.btnmodifierclient.Text = "Modifier";
            this.btnmodifierclient.UseVisualStyleBackColor = false;
            this.btnmodifierclient.Click += new System.EventHandler(this.btnmodifierclient_Click);
            // 
            // btnajouteclient
            // 
            this.btnajouteclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouteclient.FlatAppearance.BorderSize = 0;
            this.btnajouteclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouteclient.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouteclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouteclient.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouteclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouteclient.Location = new System.Drawing.Point(18, 20);
            this.btnajouteclient.Margin = new System.Windows.Forms.Padding(4);
            this.btnajouteclient.Name = "btnajouteclient";
            this.btnajouteclient.Size = new System.Drawing.Size(265, 46);
            this.btnajouteclient.TabIndex = 1;
            this.btnajouteclient.Text = "Ajouter";
            this.btnajouteclient.UseVisualStyleBackColor = false;
            this.btnajouteclient.Click += new System.EventHandler(this.btnajouteclient_Click);
            // 
            // USER_Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvguser);
            this.Controls.Add(this.btnsupprimerclient);
            this.Controls.Add(this.btnmodifierclient);
            this.Controls.Add(this.btnajouteclient);
            this.Name = "USER_Utilisateurs";
            this.Size = new System.Drawing.Size(817, 593);
            this.Load += new System.EventHandler(this.USER_Utilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvguser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnajouteclient;
        private System.Windows.Forms.Button btnmodifierclient;
        private System.Windows.Forms.Button btnsupprimerclient;
        private System.Windows.Forms.DataGridView dvguser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
