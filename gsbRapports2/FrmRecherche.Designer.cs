namespace gsbRapports2
{
    partial class FrmRecherche
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
            this.lstDate = new System.Windows.Forms.DateTimePicker();
            this.lstVisiteurs = new System.Windows.Forms.ComboBox();
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.dgRapport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textMotif = new System.Windows.Forms.TextBox();
            this.textBilan = new System.Windows.Forms.TextBox();
            this.textVisiteur = new System.Windows.Forms.TextBox();
            this.textMedecin = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visiteur";
            // 
            // lstDate
            // 
            this.lstDate.Location = new System.Drawing.Point(262, 24);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(200, 20);
            this.lstDate.TabIndex = 2;
            // 
            // lstVisiteurs
            // 
            this.lstVisiteurs.DataSource = this.bdgVisiteur;
            this.lstVisiteurs.DisplayMember = "nom";
            this.lstVisiteurs.FormattingEnabled = true;
            this.lstVisiteurs.Location = new System.Drawing.Point(569, 24);
            this.lstVisiteurs.Name = "lstVisiteurs";
            this.lstVisiteurs.Size = new System.Drawing.Size(121, 21);
            this.lstVisiteurs.TabIndex = 3;
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(gsbRapports2.visiteur);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recherche Rapport";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(767, 22);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 5;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // dgRapport
            // 
            this.dgRapport.AutoGenerateColumns = false;
            this.dgRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn});
            this.dgRapport.DataSource = this.rapportBindingSource;
            this.dgRapport.Location = new System.Drawing.Point(124, 96);
            this.dgRapport.Name = "dgRapport";
            this.dgRapport.Size = new System.Drawing.Size(643, 150);
            this.dgRapport.TabIndex = 6;
            this.dgRapport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRapport_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            // 
            // rapportBindingSource
            // 
            this.rapportBindingSource.DataSource = typeof(gsbRapports2.rapport);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Motif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bilan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Visiteur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Médecin";
            // 
            // textID
            // 
            this.textID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rapportBindingSource, "id", true));
            this.textID.Location = new System.Drawing.Point(188, 290);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 13;
            // 
            // textDate
            // 
            this.textDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rapportBindingSource, "date", true));
            this.textDate.Location = new System.Drawing.Point(188, 336);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(100, 20);
            this.textDate.TabIndex = 14;
            // 
            // textMotif
            // 
            this.textMotif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rapportBindingSource, "motif", true));
            this.textMotif.Location = new System.Drawing.Point(188, 383);
            this.textMotif.Name = "textMotif";
            this.textMotif.Size = new System.Drawing.Size(100, 20);
            this.textMotif.TabIndex = 15;
            // 
            // textBilan
            // 
            this.textBilan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rapportBindingSource, "bilan", true));
            this.textBilan.Location = new System.Drawing.Point(433, 290);
            this.textBilan.Name = "textBilan";
            this.textBilan.Size = new System.Drawing.Size(100, 20);
            this.textBilan.TabIndex = 16;
            // 
            // textVisiteur
            // 
            this.textVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rapportBindingSource, "idVisiteur", true));
            this.textVisiteur.Location = new System.Drawing.Point(433, 336);
            this.textVisiteur.Name = "textVisiteur";
            this.textVisiteur.Size = new System.Drawing.Size(100, 20);
            this.textVisiteur.TabIndex = 17;
            // 
            // textMedecin
            // 
            this.textMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rapportBindingSource, "idMedecin", true));
            this.textMedecin.Location = new System.Drawing.Point(433, 383);
            this.textMedecin.Name = "textMedecin";
            this.textMedecin.Size = new System.Drawing.Size(100, 20);
            this.textMedecin.TabIndex = 18;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(616, 286);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 19;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(615, 334);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // FrmRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.textMedecin);
            this.Controls.Add(this.textVisiteur);
            this.Controls.Add(this.textBilan);
            this.Controls.Add(this.textMotif);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgRapport);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstVisiteurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDate);
            this.Name = "FrmRecherche";
            this.Text = "FrmRecherche";
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker lstDate;
        private System.Windows.Forms.ComboBox lstVisiteurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.BindingSource bdgVisiteur;
        private System.Windows.Forms.DataGridView dgRapport;
        private System.Windows.Forms.BindingSource rapportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textMotif;
        private System.Windows.Forms.TextBox textBilan;
        private System.Windows.Forms.TextBox textVisiteur;
        private System.Windows.Forms.TextBox textMedecin;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
    }
}