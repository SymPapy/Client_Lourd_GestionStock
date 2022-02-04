
namespace GestionDeStock.PL
{
    partial class FRM_Detail_Commande
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.txtVilleC = new System.Windows.Forms.TextBox();
            this.txtPaysC = new System.Windows.Forms.TextBox();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.txttelephoneC = new System.Windows.Forms.TextBox();
            this.txtprenomC = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvgdetailCommandes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblHT = new System.Windows.Forms.Label();
            this.lblTVA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTTC = new System.Windows.Forms.Label();
            this.txtttc = new System.Windows.Forms.TextBox();
            this.txttotalht = new System.Windows.Forms.TextBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdetailCommandes)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1154, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 645);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 645);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1154, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 644);
            this.panel3.TabIndex = 5;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitre.Location = new System.Drawing.Point(458, 13);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(297, 36);
            this.lblTitre.TabIndex = 26;
            this.lblTitre.Text = "Ajouter une Commande";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnregistrer.Location = new System.Drawing.Point(570, 590);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(356, 47);
            this.btnEnregistrer.TabIndex = 27;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgProduit);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.txtrecherche);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(9, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 552);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produit";
            // 
            // dvgProduit
            // 
            this.dvgProduit.AllowUserToAddRows = false;
            this.dvgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgProduit.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dvgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.GridColor = System.Drawing.SystemColors.ControlText;
            this.dvgProduit.Location = new System.Drawing.Point(6, 67);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.RowHeadersVisible = false;
            this.dvgProduit.RowHeadersWidth = 51;
            this.dvgProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dvgProduit.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProduit.RowTemplate.ReadOnly = true;
            this.dvgProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProduit.Size = new System.Drawing.Size(378, 479);
            this.dvgProduit.TabIndex = 19;
            this.dvgProduit.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit_CellContentDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(20, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 3);
            this.panel5.TabIndex = 18;
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtrecherche.Location = new System.Drawing.Point(20, 26);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(355, 30);
            this.txtrecherche.TabIndex = 17;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            this.txtrecherche.Enter += new System.EventHandler(this.txtNom_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClient);
            this.groupBox2.Controls.Add(this.txtVilleC);
            this.groupBox2.Controls.Add(this.txtPaysC);
            this.groupBox2.Controls.Add(this.txtEmailC);
            this.groupBox2.Controls.Add(this.txttelephoneC);
            this.groupBox2.Controls.Add(this.txtprenomC);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.lblVille);
            this.groupBox2.Controls.Add(this.lblPays);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.lblTelephone);
            this.groupBox2.Controls.Add(this.lblPrenom);
            this.groupBox2.Controls.Add(this.lblNom);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(406, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 113);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Location = new System.Drawing.Point(13, 24);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(41, 32);
            this.btnClient.TabIndex = 39;
            this.btnClient.Text = "...";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // txtVilleC
            // 
            this.txtVilleC.Enabled = false;
            this.txtVilleC.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtVilleC.Location = new System.Drawing.Point(550, 73);
            this.txtVilleC.Name = "txtVilleC";
            this.txtVilleC.Size = new System.Drawing.Size(185, 27);
            this.txtVilleC.TabIndex = 38;
            // 
            // txtPaysC
            // 
            this.txtPaysC.Enabled = false;
            this.txtPaysC.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPaysC.Location = new System.Drawing.Point(343, 73);
            this.txtPaysC.Name = "txtPaysC";
            this.txtPaysC.Size = new System.Drawing.Size(150, 27);
            this.txtPaysC.TabIndex = 37;
            // 
            // txtEmailC
            // 
            this.txtEmailC.Enabled = false;
            this.txtEmailC.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtEmailC.Location = new System.Drawing.Point(66, 73);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(218, 27);
            this.txtEmailC.TabIndex = 36;
            // 
            // txttelephoneC
            // 
            this.txttelephoneC.Enabled = false;
            this.txttelephoneC.Font = new System.Drawing.Font("Calibri", 12F);
            this.txttelephoneC.Location = new System.Drawing.Point(587, 25);
            this.txttelephoneC.Name = "txttelephoneC";
            this.txttelephoneC.Size = new System.Drawing.Size(148, 27);
            this.txttelephoneC.TabIndex = 35;
            // 
            // txtprenomC
            // 
            this.txtprenomC.Enabled = false;
            this.txtprenomC.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtprenomC.Location = new System.Drawing.Point(363, 24);
            this.txtprenomC.Name = "txtprenomC";
            this.txtprenomC.Size = new System.Drawing.Size(129, 27);
            this.txtprenomC.TabIndex = 34;
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(122, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 27);
            this.txtNom.TabIndex = 33;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVille.Location = new System.Drawing.Point(499, 76);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(54, 23);
            this.lblVille.TabIndex = 32;
            this.lblVille.Text = "Ville :";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPays.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPays.Location = new System.Drawing.Point(290, 76);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(55, 23);
            this.lblPays.TabIndex = 31;
            this.lblPays.Text = "Pays :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMail.Location = new System.Drawing.Point(6, 76);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(63, 23);
            this.lblMail.TabIndex = 30;
            this.lblMail.Text = "Email :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelephone.Location = new System.Drawing.Point(491, 28);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(99, 23);
            this.lblTelephone.TabIndex = 29;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrenom.Location = new System.Drawing.Point(283, 26);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(80, 23);
            this.lblPrenom.TabIndex = 28;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNom.Location = new System.Drawing.Point(69, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(56, 23);
            this.lblNom.TabIndex = 27;
            this.lblNom.Text = "Nom :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dvgdetailCommandes);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(405, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 291);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commande";
            // 
            // dvgdetailCommandes
            // 
            this.dvgdetailCommandes.AllowUserToAddRows = false;
            this.dvgdetailCommandes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgdetailCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgdetailCommandes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgdetailCommandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgdetailCommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgdetailCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdetailCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Remise,
            this.Total});
            this.dvgdetailCommandes.ContextMenuStrip = this.contextMenuStrip2;
            this.dvgdetailCommandes.EnableHeadersVisualStyles = false;
            this.dvgdetailCommandes.GridColor = System.Drawing.SystemColors.ControlText;
            this.dvgdetailCommandes.Location = new System.Drawing.Point(6, 32);
            this.dvgdetailCommandes.Name = "dvgdetailCommandes";
            this.dvgdetailCommandes.RowHeadersVisible = false;
            this.dvgdetailCommandes.RowHeadersWidth = 51;
            this.dvgdetailCommandes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgdetailCommandes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgdetailCommandes.RowTemplate.ReadOnly = true;
            this.dvgdetailCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgdetailCommandes.Size = new System.Drawing.Size(728, 253);
            this.dvgdetailCommandes.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Remise
            // 
            this.Remise.HeaderText = "Remise";
            this.Remise.Name = "Remise";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Image = global::GestionDeStock.Properties.Resources.k;
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GestionDeStock.Properties.Resources.Deconnecte;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(550, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date Commande :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(704, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHT.Location = new System.Drawing.Point(410, 540);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(94, 23);
            this.lblHT.TabIndex = 33;
            this.lblHT.Text = "TOTAL HT :";
            // 
            // lblTVA
            // 
            this.lblTVA.AutoSize = true;
            this.lblTVA.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTVA.Location = new System.Drawing.Point(694, 540);
            this.lblTVA.Name = "lblTVA";
            this.lblTVA.Size = new System.Drawing.Size(50, 23);
            this.lblTVA.TabIndex = 34;
            this.lblTVA.Text = "TVA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(810, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "%";
            // 
            // lblTTC
            // 
            this.lblTTC.AutoSize = true;
            this.lblTTC.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTTC.Location = new System.Drawing.Point(923, 540);
            this.lblTTC.Name = "lblTTC";
            this.lblTTC.Size = new System.Drawing.Size(101, 23);
            this.lblTTC.TabIndex = 31;
            this.lblTTC.Text = "TOTAL TTC :";
            // 
            // txtttc
            // 
            this.txtttc.Enabled = false;
            this.txtttc.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtttc.Location = new System.Drawing.Point(1023, 539);
            this.txtttc.Name = "txtttc";
            this.txtttc.Size = new System.Drawing.Size(123, 27);
            this.txtttc.TabIndex = 37;
            // 
            // txttotalht
            // 
            this.txttotalht.Enabled = false;
            this.txttotalht.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalht.Location = new System.Drawing.Point(510, 540);
            this.txttotalht.Name = "txttotalht";
            this.txttotalht.Size = new System.Drawing.Size(129, 27);
            this.txttotalht.TabIndex = 35;
            // 
            // btnquitter
            // 
            this.btnquitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(1111, 6);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(37, 37);
            this.btnquitter.TabIndex = 25;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // txtTVA
            // 
            this.txtTVA.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtTVA.Location = new System.Drawing.Point(749, 536);
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.Size = new System.Drawing.Size(64, 30);
            this.txtTVA.TabIndex = 38;
            this.txtTVA.TextChanged += new System.EventHandler(this.txtTVA_TextChanged_1);
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(GestionDeStock.Produit);
            // 
            // FRM_Detail_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1155, 646);
            this.Controls.Add(this.txtTVA);
            this.Controls.Add(this.txtttc);
            this.Controls.Add(this.txttotalht);
            this.Controls.Add(this.lblTTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTVA);
            this.Controls.Add(this.lblHT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Detail_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Detail_Commande";
            this.Load += new System.EventHandler(this.FRM_Detail_Commande_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdetailCommandes)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtrecherche;
        public System.Windows.Forms.Label lblVille;
        public System.Windows.Forms.Label lblPays;
        public System.Windows.Forms.Label lblMail;
        public System.Windows.Forms.Label lblTelephone;
        public System.Windows.Forms.Label lblPrenom;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label lblHT;
        public System.Windows.Forms.Label lblTVA;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTTC;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.TextBox txtVilleC;
        private System.Windows.Forms.TextBox txtPaysC;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.TextBox txttelephoneC;
        private System.Windows.Forms.TextBox txtprenomC;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dvgdetailCommandes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        public System.Windows.Forms.TextBox txtTVA;
        public System.Windows.Forms.TextBox txtttc;
        public System.Windows.Forms.TextBox txttotalht;
    }
}