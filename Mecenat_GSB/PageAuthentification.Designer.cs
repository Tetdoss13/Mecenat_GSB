namespace Mecenat_GSB
{
    partial class PageAuthentification
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAuthentification));
            this.btn_connexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAff = new System.Windows.Forms.Label();
            this.cbx_mdp = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_nomutilisateur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_authentification = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_authentification)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connexion
            // 
            this.btn_connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.ForeColor = System.Drawing.Color.White;
            this.btn_connexion.Location = new System.Drawing.Point(119, 254);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(144, 47);
            this.btn_connexion.TabIndex = 0;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbAff);
            this.panel1.Controls.Add(this.cbx_mdp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_enregistrer);
            this.panel1.Controls.Add(this.btn_connexion);
            this.panel1.Controls.Add(this.txt_mdp);
            this.panel1.Controls.Add(this.txt_nomutilisateur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(110, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 328);
            this.panel1.TabIndex = 1;
            // 
            // lbAff
            // 
            this.lbAff.AutoSize = true;
            this.lbAff.Location = new System.Drawing.Point(17, 305);
            this.lbAff.Name = "lbAff";
            this.lbAff.Size = new System.Drawing.Size(35, 13);
            this.lbAff.TabIndex = 9;
            this.lbAff.Text = "label6";
            // 
            // cbx_mdp
            // 
            this.cbx_mdp.AutoSize = true;
            this.cbx_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_mdp.ForeColor = System.Drawing.Color.Black;
            this.cbx_mdp.Location = new System.Drawing.Point(398, 217);
            this.cbx_mdp.Name = "cbx_mdp";
            this.cbx_mdp.Size = new System.Drawing.Size(128, 17);
            this.cbx_mdp.TabIndex = 8;
            this.cbx_mdp.Text = "Afficher mot de passe";
            this.cbx_mdp.UseVisualStyleBackColor = true;
            this.cbx_mdp.CheckedChanged += new System.EventHandler(this.cbx_mdp_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(40, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Le mot de passe est requis !";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Le nom d\'utilisateur est requis !";
            this.label4.Visible = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer.Location = new System.Drawing.Point(314, 254);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(144, 47);
            this.btn_enregistrer.TabIndex = 5;
            this.btn_enregistrer.Text = "S\'enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // txt_mdp
            // 
            this.txt_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mdp.Location = new System.Drawing.Point(44, 185);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(482, 29);
            this.txt_mdp.TabIndex = 4;
            this.txt_mdp.UseSystemPasswordChar = true;
            // 
            // txt_nomutilisateur
            // 
            this.txt_nomutilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomutilisateur.Location = new System.Drawing.Point(44, 96);
            this.txt_nomutilisateur.Name = "txt_nomutilisateur";
            this.txt_nomutilisateur.Size = new System.Drawing.Size(482, 29);
            this.txt_nomutilisateur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom d\'utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentification";
            // 
            // dg_authentification
            // 
            this.dg_authentification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_authentification.Location = new System.Drawing.Point(554, 297);
            this.dg_authentification.Name = "dg_authentification";
            this.dg_authentification.Size = new System.Drawing.Size(234, 141);
            this.dg_authentification.TabIndex = 9;
        
            // 
            // PageAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_authentification);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageAuthentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'authentification";
            this.Load += new System.EventHandler(this.PageAuthentification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_authentification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_nomutilisateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbx_mdp;
        private System.Windows.Forms.DataGridView dg_authentification;
        private System.Windows.Forms.Label lbAff;
    }
}

