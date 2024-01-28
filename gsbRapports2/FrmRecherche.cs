using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports2
{
    public partial class FrmRecherche : Form
    {
        private gsbrapportsEntities gsbEntities;
        private List<rapport> Rapports;
        
        public FrmRecherche(gsbrapportsEntities gsbEntities)
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

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            visiteur idVisiteurSelectionne = (visiteur)lstVisiteurs.SelectedValue;
            DateTime dateSelectionnee = lstDate.Value.Date;

            List<rapport> rapportsTrouves = getRapport(idVisiteurSelectionne.id, dateSelectionnee);

            //messages de débogage
            MessageBox.Show($"Nombre de rapports trouvés : {rapportsTrouves.Count}");
        }

        int indexRow;
        private void dgRapport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgRapport.Rows[indexRow];

            textID.Text = row.Cells[0].Value.ToString();
            textDate.Text = row.Cells[1].Value.ToString();
            textMotif.Text = row.Cells[2].Value.ToString();
            textBilan.Text = row.Cells[3].Value.ToString();
            textVisiteur.Text = row.Cells[4].Value.ToString();
            textMedecin.Text = row.Cells[5].Value.ToString();
        }

        private rapport GetSelectedRapport()
        {
            int rapportId = Convert.ToInt16(textID.Text);
            return gsbEntities.rapports.FirstOrDefault(r => r.id == rapportId);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                rapport existingRapport = GetSelectedRapport();

                existingRapport.date = Convert.ToDateTime(textDate.Text);
                existingRapport.motif = textMotif.Text;
                existingRapport.bilan = textBilan.Text;
                existingRapport.idVisiteur = textVisiteur.Text;
                existingRapport.idMedecin = Convert.ToInt16(textMedecin.Text);
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
