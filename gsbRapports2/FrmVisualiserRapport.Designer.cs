namespace gsbRapports2
{
    partial class FrmVisualiserRapport
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
            this.lstMedecin = new System.Windows.Forms.ComboBox();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médecin :";
            // 
            // lstMedecin
            // 
            this.lstMedecin.DataSource = this.medecinBindingSource;
            this.lstMedecin.DisplayMember = "nom";
            this.lstMedecin.FormattingEnabled = true;
            this.lstMedecin.Location = new System.Drawing.Point(223, 163);
            this.lstMedecin.Name = "lstMedecin";
            this.lstMedecin.Size = new System.Drawing.Size(121, 21);
            this.lstMedecin.TabIndex = 1;
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataSource = typeof(gsbRapports2.medecin);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Générer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVisualiserRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstMedecin);
            this.Controls.Add(this.label1);
            this.Name = "FrmVisualiserRapport";
            this.Text = "FrmVisualiserRapport";
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstMedecin;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private System.Windows.Forms.Button button1;
    }
}