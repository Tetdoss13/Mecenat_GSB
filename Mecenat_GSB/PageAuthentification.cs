using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


namespace Mecenat_GSB
{
    public partial class PageAuthentification : Form
    {

        BDD_MECENATEntities1 G = new BDD_MECENATEntities1();
        public PageAuthentification()
        {
            InitializeComponent();
        }

        private void cbx_mdp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_mdp.Checked)
            {
                txt_mdp.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mdp.UseSystemPasswordChar = true;
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            new PageEnregistrement().Show();
            this.Hide();
        }

        private void PageAuthentification_Load(object sender, EventArgs e)
        {
            string recup = "test@test.fr";
            dg_authentification.DataSource = G.UTILISATEUR.ToList();
            var query = G.UTILISATEUR.Where(k => k.LOGIN_UTILISATEUR == recup).Select(p => new { p.NOM_UTILISATEUR, p.PRENOM_UTILISATEUR });
            var query2 = G.UTILISATEUR.Select(p => new { p.NOM_UTILISATEUR, p.PRENOM_UTILISATEUR });

            foreach (var order in query)
            {
                lbAff.Text = order.NOM_UTILISATEUR + order.PRENOM_UTILISATEUR;
                //MessageBox.Show(order.NOMUSER, order.PRENOMUSER);
            }

            dg_authentification.DataSource = query2.ToList();
        }
    }
}
