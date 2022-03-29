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
            this.lblNomeSito = new System.Windows.Forms.Label();
            this.txtboxNomeSito = new System.Windows.Forms.TextBox();
            this.lblNomeUtente = new System.Windows.Forms.Label();
            this.txtboxNomeUtente = new System.Windows.Forms.TextBox();
            this.btnGeneraPassword = new System.Windows.Forms.Button();
            this.lblPasswordOttenuta = new System.Windows.Forms.Label();
            this.lblRisultatoPassword = new System.Windows.Forms.Label();
            this.btnSalvaPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeSito
            // 
            this.lblNomeSito.AutoSize = true;
            this.lblNomeSito.Location = new System.Drawing.Point(299, 31);
            this.lblNomeSito.Name = "lblNomeSito";
            this.lblNomeSito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNomeSito.Size = new System.Drawing.Size(113, 13);
            this.lblNomeSito.TabIndex = 0;
            this.lblNomeSito.Text = "   Inserire nome sito     ";
            // 
            // txtboxNomeSito
            // 
            this.txtboxNomeSito.Location = new System.Drawing.Point(302, 62);
            this.txtboxNomeSito.Name = "txtboxNomeSito";
            this.txtboxNomeSito.Size = new System.Drawing.Size(100, 20);
            this.txtboxNomeSito.TabIndex = 1;
            this.txtboxNomeSito.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNomeUtente
            // 
            this.lblNomeUtente.AutoSize = true;
            this.lblNomeUtente.Location = new System.Drawing.Point(299, 109);
            this.lblNomeUtente.Name = "lblNomeUtente";
            this.lblNomeUtente.Size = new System.Drawing.Size(103, 13);
            this.lblNomeUtente.TabIndex = 2;
            this.lblNomeUtente.Text = "Inserire nome utente";
            this.lblNomeUtente.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxNomeUtente
            // 
            this.txtboxNomeUtente.Location = new System.Drawing.Point(302, 145);
            this.txtboxNomeUtente.Name = "txtboxNomeUtente";
            this.txtboxNomeUtente.Size = new System.Drawing.Size(100, 20);
            this.txtboxNomeUtente.TabIndex = 3;
            // 
            // btnGeneraPassword
            // 
            this.btnGeneraPassword.Location = new System.Drawing.Point(298, 212);
            this.btnGeneraPassword.Name = "btnGeneraPassword";
            this.btnGeneraPassword.Size = new System.Drawing.Size(114, 23);
            this.btnGeneraPassword.TabIndex = 4;
            this.btnGeneraPassword.Text = "Genera Password";
            this.btnGeneraPassword.UseVisualStyleBackColor = true;
            // 
            // lblPasswordOttenuta
            // 
            this.lblPasswordOttenuta.AutoSize = true;
            this.lblPasswordOttenuta.Location = new System.Drawing.Point(295, 272);
            this.lblPasswordOttenuta.Name = "lblPasswordOttenuta";
            this.lblPasswordOttenuta.Size = new System.Drawing.Size(115, 13);
            this.lblPasswordOttenuta.TabIndex = 5;
            this.lblPasswordOttenuta.Text = "   Password Ottenuta   ";
            this.lblPasswordOttenuta.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRisultatoPassword
            // 
            this.lblRisultatoPassword.AutoSize = true;
            this.lblRisultatoPassword.Location = new System.Drawing.Point(329, 306);
            this.lblRisultatoPassword.Name = "lblRisultatoPassword";
            this.lblRisultatoPassword.Size = new System.Drawing.Size(35, 13);
            this.lblRisultatoPassword.TabIndex = 6;
            this.lblRisultatoPassword.Text = "label4";
            // 
            // btnSalvaPassword
            // 
            this.btnSalvaPassword.Location = new System.Drawing.Point(271, 344);
            this.btnSalvaPassword.Name = "btnSalvaPassword";
            this.btnSalvaPassword.Size = new System.Drawing.Size(181, 23);
            this.btnSalvaPassword.TabIndex = 7;
            this.btnSalvaPassword.Text = "Salva password in locale";
            this.btnSalvaPassword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvaPassword);
            this.Controls.Add(this.lblRisultatoPassword);
            this.Controls.Add(this.lblPasswordOttenuta);
            this.Controls.Add(this.btnGeneraPassword);
            this.Controls.Add(this.txtboxNomeUtente);
            this.Controls.Add(this.lblNomeUtente);
            this.Controls.Add(this.txtboxNomeSito);
            this.Controls.Add(this.lblNomeSito);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

