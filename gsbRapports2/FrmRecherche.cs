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
        private gsbrapports2021Entities gsbEntities;
        private List<rapport> Rapports;
        
        public FrmRecherche(gsbrapports2021Entities gsbEntities)
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
