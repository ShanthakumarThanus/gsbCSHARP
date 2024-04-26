namespace gsbRapports2
{
    partial class FrmRechercheParDate
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgRapport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstVisiteurs = new System.Windows.Forms.ComboBox();
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lstDate = new System.Windows.Forms.DateTimePicker();
            this.lstDate2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(1472, 137);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(112, 35);
            this.btnEnregistrer.TabIndex = 27;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
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
            this.idMedecinDataGridViewTextBoxColumn,
            this.medecinDataGridViewTextBoxColumn,
            this.offrirsDataGridViewTextBoxColumn,
            this.visiteurDataGridViewTextBoxColumn});
            this.dgRapport.DataSource = this.rapportBindingSource;
            this.dgRapport.Location = new System.Drawing.Point(401, 199);
            this.dgRapport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgRapport.Name = "dgRapport";
            this.dgRapport.RowHeadersWidth = 62;
            this.dgRapport.Size = new System.Drawing.Size(815, 231);
            this.dgRapport.TabIndex = 26;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.Width = 150;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            this.bilanDataGridViewTextBoxColumn.Width = 150;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            this.idVisiteurDataGridViewTextBoxColumn.Width = 150;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.Width = 150;
            // 
            // medecinDataGridViewTextBoxColumn
            // 
            this.medecinDataGridViewTextBoxColumn.DataPropertyName = "medecin";
            this.medecinDataGridViewTextBoxColumn.HeaderText = "medecin";
            this.medecinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.medecinDataGridViewTextBoxColumn.Name = "medecinDataGridViewTextBoxColumn";
            this.medecinDataGridViewTextBoxColumn.Visible = false;
            this.medecinDataGridViewTextBoxColumn.Width = 150;
            // 
            // offrirsDataGridViewTextBoxColumn
            // 
            this.offrirsDataGridViewTextBoxColumn.DataPropertyName = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.HeaderText = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.offrirsDataGridViewTextBoxColumn.Name = "offrirsDataGridViewTextBoxColumn";
            this.offrirsDataGridViewTextBoxColumn.Visible = false;
            this.offrirsDataGridViewTextBoxColumn.Width = 150;
            // 
            // visiteurDataGridViewTextBoxColumn
            // 
            this.visiteurDataGridViewTextBoxColumn.DataPropertyName = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.HeaderText = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visiteurDataGridViewTextBoxColumn.Name = "visiteurDataGridViewTextBoxColumn";
            this.visiteurDataGridViewTextBoxColumn.Visible = false;
            this.visiteurDataGridViewTextBoxColumn.Width = 150;
            // 
            // rapportBindingSource
            // 
            this.rapportBindingSource.DataSource = typeof(gsbRapports2.rapport);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(1472, 78);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(112, 35);
            this.btnRecherche.TabIndex = 25;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Recherche Rapport par date";
            // 
            // lstVisiteurs
            // 
            this.lstVisiteurs.DataSource = this.bdgVisiteur;
            this.lstVisiteurs.DisplayMember = "nom";
            this.lstVisiteurs.FormattingEnabled = true;
            this.lstVisiteurs.Location = new System.Drawing.Point(1204, 103);
            this.lstVisiteurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstVisiteurs.Name = "lstVisiteurs";
            this.lstVisiteurs.Size = new System.Drawing.Size(180, 28);
            this.lstVisiteurs.TabIndex = 23;
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(gsbRapports2.visiteur);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1114, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Visiteur";
            // 
            // lstDate
            // 
            this.lstDate.Location = new System.Drawing.Point(715, 42);
            this.lstDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(298, 26);
            this.lstDate.TabIndex = 22;
            // 
            // lstDate2
            // 
            this.lstDate2.Location = new System.Drawing.Point(1086, 42);
            this.lstDate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDate2.Name = "lstDate2";
            this.lstDate2.Size = new System.Drawing.Size(298, 26);
            this.lstDate2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1033, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "et";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Choisissez l\'intervalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Entre :";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(1453, 296);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(62, 20);
            this.labelCount.TabIndex = 32;
            this.labelCount.Text = "Visiteur";
            // 
            // FrmRechercheParDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 853);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDate2);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgRapport);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstVisiteurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDate);
            this.Name = "FrmRechercheParDate";
            this.Text = "FrmRechercheParDate";
            ((System.ComponentModel.ISupportInitialize)(this.dgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dgRapport;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lstVisiteurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker lstDate;
        private System.Windows.Forms.BindingSource bdgVisiteur;
        private System.Windows.Forms.BindingSource rapportBindingSource;
        private System.Windows.Forms.DateTimePicker lstDate2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelCount;
    }
}