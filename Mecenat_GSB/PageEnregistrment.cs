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
    public partial class PageEnregistrement : Form
    {
        public PageEnregistrement()
        {
            InitializeComponent();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            new PageAuthentification().Show();
            this.Hide();
        }
    }
}
