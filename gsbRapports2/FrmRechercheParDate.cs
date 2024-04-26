using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace gsbRapports2
{
    public partial class FrmRechercheParDate : Form
    {
        private gsbrapports2021Entities gsbEntities;
        private List<rapport> Rapports;

        public FrmRechercheParDate(gsbrapports2021Entities gsbEntities)
        {
            InitializeComponent();
            this.gsbEntities = gsbEntities;
            this.bdgVisiteur.DataSource = gsbEntities.visiteurs.ToList();
            this.rapportBindingSource.DataSource = gsbEntities.rapports.ToList();
        }


        private List<rapport> getRapport(string id, DateTime date)
        {
            var req = from rapport in this.gsbEntities.rapports
                      where rapport.idVisiteur == id && rapport.date == date
                      select rapport;

            this.rapportBindingSource.DataSource = req.ToList();

            return req.ToList();
        }

        private List<rapport> getRapportParDate(string id, DateTime date1, DateTime date2)
        {
            var req = from rapport in this.gsbEntities.rapports
                      where rapport.idVisiteur == id && (rapport.date >= date1 & rapport.date <= date2)
                      select rapport;

            this.rapportBindingSource.DataSource = req.ToList();

            return req.ToList();
        }



        private void btnRecherche_Click_1(object sender, EventArgs e)
        {
            visiteur idVisiteurSelectionne = (visiteur)lstVisiteurs.SelectedValue;
            DateTime dateSelectionnee = lstDate.Value.Date;
            DateTime dateSelectionnee2 = lstDate2.Value.Date;

            List<rapport> rapportsTrouves = getRapportParDate(idVisiteurSelectionne.id, dateSelectionnee, dateSelectionnee2);

            if (lstDate.Value > lstDate2.Value)
            {
                MessageBox.Show("L'intervalle saisie est incorrecte. Veuillez réessayer.");
            }
            else if (rapportsTrouves.Count == 0 )
            {
                MessageBox.Show("Il n'y a pas de rapport trouvé pour cette intervalle");
            }
            else
            {
                MessageBox.Show($"Nombre de rapports trouvés : {rapportsTrouves.Count}");
                string c = rapportsTrouves.Count.ToString();
                
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.rapportBindingSource.EndEdit();
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
