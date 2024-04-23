namespace gsbRapports2
{
    partial class FrmRapport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstVisiteur = new System.Windows.Forms.ComboBox();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstMedecin = new System.Windows.Forms.ComboBox();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstMedicament = new System.Windows.Forms.ComboBox();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateRapport = new System.Windows.Forms.DateTimePicker();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.bdgrapport = new System.Windows.Forms.BindingSource(this.components);
            this.enregistrer = new System.Windows.Forms.Button();
            this.bdgmedicament = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgrapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgmedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visiteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Médecin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Famille de médicament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motif";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bilan";
            // 
            // lstVisiteur
            // 
            this.lstVisiteur.DataSource = this.visiteurBindingSource;
            this.lstVisiteur.DisplayMember = "nom";
            this.lstVisiteur.FormattingEnabled = true;
            this.lstVisiteur.Location = new System.Drawing.Point(301, 52);
            this.lstVisiteur.Name = "lstVisiteur";
            this.lstVisiteur.Size = new System.Drawing.Size(121, 21);
            this.lstVisiteur.TabIndex = 6;
            // 
            // visiteurBindingSource
            // 
            this.visiteurBindingSource.DataSource = typeof(gsbRapports2.visiteur);
            // 
            // lstMedecin
            // 
            this.lstMedecin.DataSource = this.medecinBindingSource;
            this.lstMedecin.DisplayMember = "nom";
            this.lstMedecin.FormattingEnabled = true;
            this.lstMedecin.Location = new System.Drawing.Point(301, 106);
            this.lstMedecin.Name = "lstMedecin";
            this.lstMedecin.Size = new System.Drawing.Size(121, 21);
            this.lstMedecin.TabIndex = 7;
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataSource = typeof(gsbRapports2.medecin);
            // 
            // lstMedicament
            // 
            this.lstMedicament.DataSource = this.familleBindingSource;
            this.lstMedicament.DisplayMember = "id";
            this.lstMedicament.FormattingEnabled = true;
            this.lstMedicament.Location = new System.Drawing.Point(301, 160);
            this.lstMedicament.Name = "lstMedicament";
            this.lstMedicament.Size = new System.Drawing.Size(121, 21);
            this.lstMedicament.TabIndex = 8;
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(gsbRapports2.famille);
            // 
            // dateRapport
            // 
            this.dateRapport.Location = new System.Drawing.Point(301, 212);
            this.dateRapport.Name = "dateRapport";
            this.dateRapport.Size = new System.Drawing.Size(200, 20);
            this.dateRapport.TabIndex = 9;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(301, 271);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(100, 20);
            this.txtMotif.TabIndex = 10;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(301, 322);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(100, 20);
            this.txtBilan.TabIndex = 11;
            // 
            // bdgrapport
            // 
            this.bdgrapport.DataSource = typeof(gsbRapports2.rapport);
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(301, 374);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(75, 23);
            this.enregistrer.TabIndex = 12;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // bdgmedicament
            // 
            this.bdgmedicament.DataSource = typeof(gsbRapports2.medicament);
            // 
            // FrmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.dateRapport);
            this.Controls.Add(this.lstMedicament);
            this.Controls.Add(this.lstMedecin);
            this.Controls.Add(this.lstVisiteur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRapport";
            this.Text = "FrmRapport";
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgrapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgmedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lstVisiteur;
        private System.Windows.Forms.ComboBox lstMedecin;
        private System.Windows.Forms.ComboBox lstMedicament;
        private System.Windows.Forms.DateTimePicker dateRapport;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.BindingSource bdgrapport;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.BindingSource bdgmedicament;
    }
}