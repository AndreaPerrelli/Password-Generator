using System;

namespace Password_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNomeSito = new System.Windows.Forms.Label();
            this.txtboxNomeSito = new System.Windows.Forms.TextBox();
            this.lblNomeUtente = new System.Windows.Forms.Label();
            this.txtboxNomeUtente = new System.Windows.Forms.TextBox();
            this.btnGeneraPassword = new System.Windows.Forms.Button();
            this.lblPasswordOttenuta = new System.Windows.Forms.Label();
            this.lblRisultatoPassword = new System.Windows.Forms.Label();
            this.btnSalvaPassword = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeSito
            // 
            resources.ApplyResources(this.lblNomeSito, "lblNomeSito");
            this.lblNomeSito.ForeColor = System.Drawing.Color.LightGreen;
            this.lblNomeSito.Name = "lblNomeSito";
            this.lblNomeSito.Text = Properties.Resources.lblNomeSito;
            // 
            // txtboxNomeSito
            // 
            this.txtboxNomeSito.BackColor = System.Drawing.Color.Black;
            this.txtboxNomeSito.ForeColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.txtboxNomeSito, "txtboxNomeSito");
            this.txtboxNomeSito.Name = "txtboxNomeSito";
            this.txtboxNomeSito.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNomeUtente
            // 
            resources.ApplyResources(this.lblNomeUtente, "lblNomeUtente");
            this.lblNomeUtente.ForeColor = System.Drawing.Color.LightGreen;
            this.lblNomeUtente.Name = "lblNomeUtente";
            this.lblNomeUtente.Click += new System.EventHandler(this.label2_Click);
            this.lblNomeUtente.Text = Properties.Resources.lblNomeUtente;
            // 
            // txtboxNomeUtente
            // 
            this.txtboxNomeUtente.BackColor = System.Drawing.Color.Black;
            this.txtboxNomeUtente.ForeColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.txtboxNomeUtente, "txtboxNomeUtente");
            this.txtboxNomeUtente.Name = "txtboxNomeUtente";
            // 
            // btnGeneraPassword
            // 
            this.btnGeneraPassword.BackColor = System.Drawing.Color.Black;
            this.btnGeneraPassword.ForeColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.btnGeneraPassword, "btnGeneraPassword");
            this.btnGeneraPassword.Name = "btnGeneraPassword";
            this.btnGeneraPassword.UseVisualStyleBackColor = false;
            this.btnGeneraPassword.Click += new System.EventHandler(this.btnGeneraPassword_Click);
            this.btnGeneraPassword.Text = Properties.Resources.btnGeneraPassword;
            // 
            // lblPasswordOttenuta
            // 
            resources.ApplyResources(this.lblPasswordOttenuta, "lblPasswordOttenuta");
            this.lblPasswordOttenuta.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPasswordOttenuta.Name = "lblPasswordOttenuta";
            this.lblPasswordOttenuta.Click += new System.EventHandler(this.label3_Click);
            this.lblPasswordOttenuta.Text = Properties.Resources.lblPasswordOttenuta;
            // 
            // lblRisultatoPassword
            // 
            resources.ApplyResources(this.lblRisultatoPassword, "lblRisultatoPassword");
            this.lblRisultatoPassword.ForeColor = System.Drawing.Color.LightGreen;
            this.lblRisultatoPassword.Name = "lblRisultatoPassword";
            // 
            // btnSalvaPassword
            // 
            this.btnSalvaPassword.BackColor = System.Drawing.Color.Black;
            this.btnSalvaPassword.ForeColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.btnSalvaPassword, "btnSalvaPassword");
            this.btnSalvaPassword.Name = "btnSalvaPassword";
            this.btnSalvaPassword.UseVisualStyleBackColor = false;
            this.btnSalvaPassword.Click += new System.EventHandler(this.btnSalvaPassword_Click);
            this.btnSalvaPassword.Text = Properties.Resources.btnSalvaPassword;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);


            //
            // pathFileSalvato
            //
            this.pathFileSalvato = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\password.txt";

            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSalvaPassword);
            this.Controls.Add(this.lblRisultatoPassword);
            this.Controls.Add(this.lblPasswordOttenuta);
            this.Controls.Add(this.btnGeneraPassword);
            this.Controls.Add(this.txtboxNomeUtente);
            this.Controls.Add(this.lblNomeUtente);
            this.Controls.Add(this.txtboxNomeSito);
            this.Controls.Add(this.lblNomeSito);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeSito;
        private System.Windows.Forms.TextBox txtboxNomeSito;
        private System.Windows.Forms.Label lblNomeUtente;
        private System.Windows.Forms.TextBox txtboxNomeUtente;
        private System.Windows.Forms.Button btnGeneraPassword;
        private System.Windows.Forms.Label lblPasswordOttenuta;
        private System.Windows.Forms.Label lblRisultatoPassword;
        private System.Windows.Forms.Button btnSalvaPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

