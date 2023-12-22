using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports2
{
    public partial class FrmRapport : Form
    {
        private gsbrapportsEntities gsbEntities;
        public FrmRapport(gsbrapportsEntities gsbEntities)
        {
            InitializeComponent();
            this.gsbEntities = gsbEntities;
            this.visiteurBindingSource.DataSource = gsbEntities.visiteurs.ToList();    
            this.medecinBindingSource.DataSource = gsbEntities.medecins.ToList();
            this.familleBindingSource.DataSource = gsbEntities.familles.ToList();
        }

        private int getNumRapport() //à peut-être ajouter le champ id dans le formulaire et le mettre en read only
        {
            var reqDernier = (from ra in this.gsbEntities.rapports
                              orderby ra.id descending
                              select ra);
            rapport dernierRapport = reqDernier.First();
            int n = dernierRapport.id + 1;
            return n;
        }

        private rapport newRapport()
        {
            visiteur v = (visiteur)lstVisiteur.SelectedItem;
            medecin m = (medecin)lstMedecin.SelectedItem;
            rapport newRapport = new rapport();
            newRapport.id = getNumRapport();
            newRapport.date = dateRapport.Value;
            newRapport.motif = txtMotif.Text;
            newRapport.bilan = txtBilan.Text;
            newRapport.idVisiteur = v.id;
            newRapport.idMedecin = m.id;
            return newRapport;
        }

        private void enregistrer_Click(object sender, EventArgs e) // "Intéressons-nous au bouton d’ajout du navigateur."
        {
            this.bdgrapport.EndEdit();
            try
            {
                this.gsbEntities.rapports.Add(newRapport());
                this.gsbEntities.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement du rapport : {ex.Message}");
            }
        }
    }
}
