using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecenat_GSB
{
    public partial class PageAuthentification : Form
    {
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
       
    }
}
