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
        private gsbrapports2021Entities gsbEntities;
        public FrmRapport(gsbrapports2021Entities gsbEntities)
        {
            InitializeComponent();
            this.gsbEntities = gsbEntities;
            this.visiteurBindingSource.DataSource = gsbEntities.visiteurs.ToList();    
            this.medecinBindingSource.DataSource = gsbEntities.medecins.ToList();
            this.familleBindingSource.DataSource = gsbEntities.familles.ToList();

            this.bdgmedicament.DataSource = gsbEntities.medicaments.ToList();
        }

        private int getNumRapport()
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

        //private offrir newOffrir()
        //{
        //    rapport r = newRapport(); // Obtenez le rapport associé à cette instance de nouveau rapport

        //    // Ne modifiez pas l'ID du rapport ici, utilisez plutôt celui de l'instance existante
        //    // r.id = getNumRapport() + 1;

        //    medicament m = (medicament)lstMedicament.SelectedItem;
        //    offrir newOffrir = new offrir();
        //    newOffrir.idRapport = r.id;
        //    newOffrir.idMedicament = m.idFamille;
        //    newOffrir.quantite = 1;
        //    return newOffrir;
        //}

        private offrir newOffrir(int idRapport)
        {
            offrir off = new offrir();
            medicament m = (medicament)lstMedicament.SelectedItem;
            off.idMedicament = m.id;
            off.idRapport = idRapport;
            off.quantite = 1;
            return off;
        }



        private void enregistrer_Click(object sender, EventArgs e) // "Intéressons-nous au b((souton d’ajout du navigateur."
        {
            this.bdgrapport.EndEdit();
            this.bdgmedicament.EndEdit();
            try
            {
                rapport rap = newRapport();
                this.gsbEntities.rapports.Add(rap);
                

                offrir off = newOffrir(rap.id);
                this.gsbEntities.offrirs.Add(off); 
                this.gsbEntities.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Erreur lors de l'enregistrement du rapport : {ex.InnerException.Message}");
                }
                else
                {
                    MessageBox.Show($"Erreur lors de l'enregistrement du rapport : {ex.Message}");
                }
            }

        }
    }
}
