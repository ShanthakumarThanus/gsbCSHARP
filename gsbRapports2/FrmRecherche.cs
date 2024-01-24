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
    public partial class FrmRecherche : Form
    {
        private gsbrapportsEntities gsbEntities;
        
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

        private void dgRapport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgRapport.Rows[e.RowIndex];

                textID.Text = row.Cells["id"].Value.ToString();
                textDate.Text = row.Cells["date"].Value.ToString();
                textMotif.Text = row.Cells["motif"].Value.ToString();
                textBilan.Text = row.Cells["bilan"].Value.ToString();
                textVisiteur.Text = row.Cells["idVisiteur"].Value.ToString();
                textMedecin.Text = row.Cells["idMedecin"].Value.ToString();
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            visiteur idVisiteurSelectionne = (visiteur)lstVisiteurs.SelectedValue;
            DateTime dateSelectionnee = lstDate.Value.Date;

            List<rapport> rapportsTrouves = getRapport(idVisiteurSelectionne.id, dateSelectionnee);

            //messages de débogage
            MessageBox.Show($"Nombre de rapports trouvés : {rapportsTrouves.Count}");
        }
    }
}
