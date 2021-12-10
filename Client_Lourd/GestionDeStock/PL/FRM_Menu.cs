using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(281, 620);
            pnlParamettrer.Visible = false;
        }

        //**************************** DESACTIVE LE FORMULAIRE ************************************
        void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncommande.Enabled = false;
            btncategorie.Enabled = false;
            btnutilisateur.Enabled = false;
            btncopie.Enabled = false;
            btnrestaure.Enabled = false;
            btndeconnecter.Enabled = false;
            pnlBut.Enabled = false;
            // connecter activé
            btnconnecte.Enabled = true;
        }

        //**************************** ACTIVE LE FORMULAIRE ************************************
        public void activerform()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncommande.Enabled = true;
            btncategorie.Enabled = true;
            btnutilisateur.Enabled = true;
            btncopie.Enabled = true;
            btnrestaure.Enabled = true;
            btndeconnecter.Enabled = true;
            pnlBut.Enabled = true;
            // connecter désactivé
            btnconnecte.Enabled = false;
            pnlParamettrer.Visible = false;
        }

        //*******************************************************
        //**
        //************* EVENEMENT CLICK FERMER APPLICATION
        //**
        //*******************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //*******************************************************
        //**
        //************* EVENEMENT CLICK REDUIR APPLICATION
        //**
        //*******************************************************
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //*******************************************************
        //**
        //************* EVENEMENT CLICK AGRANDIRE / RETRECIR PANEL GAUCHE
        //**
        //*******************************************************
        private void button3_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 281)
            {
                panel1.Size = new Size(72, 620);
            }else
            {
                panel1.Size = new Size(281, 620);
            }
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top; // Ajoute le selecteur du panel
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top; // Ajoute le selecteur du panel
            if(!pnlafichier.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlafichier.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }else
            {
                USER_Liste_Client.Instance.BringToFront();
            }
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top; // Ajoute le selecteur du panel
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top; // Ajoute le selecteur du panel
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnutilisateur.Top; // Ajoute le selecteur du panel
        }

        private void pnlBut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnparamettre_Click(object sender, EventArgs e)
        {
            pnlParamettrer.Size = new Size(302, 178);
            pnlParamettrer.Visible = !pnlParamettrer.Visible;
        }

        //*******************************************************
        //**
        //************* EVENEMENT CLICK AFFICHE LE FORMULAIRE DE CONNEXION USER
        //**
        //*******************************************************
        private void button4_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmC = new FRM_Connexion(this); // this  = FRM_Menu
            frmC.ShowDialog();
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }
    }
}
