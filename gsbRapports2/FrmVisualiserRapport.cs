using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace gsbRapports2
{
    public partial class FrmVisualiserRapport : Form
    {
        private gsbrapports2021Entities gsbEntities;
        public FrmVisualiserRapport(gsbrapports2021Entities gsbEntities)
        {
            InitializeComponent();
            this.gsbEntities = gsbEntities;
            this.medecinBindingSource.DataSource = gsbEntities.medecins.ToList();
        }

        private List<rapport> getRapport(int id)
        {
            var req = from rapport in this.gsbEntities.rapports
                      where rapport.idMedecin == id
                      select rapport;

            return req.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medecin filtre1 = (medecin)lstMedecin.SelectedValue;

            List<rapport> rapports = getRapport(filtre1.id);

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Rapports");
            xmlDoc.AppendChild(root);

            foreach (var rapportItem in rapports)
            {
                XmlElement rapportElement = xmlDoc.CreateElement("Rapport");
                rapportElement.SetAttribute("ID", rapportItem.id.ToString());
                rapportElement.SetAttribute("Date", rapportItem.date.ToString());
                rapportElement.SetAttribute("Motif", rapportItem.motif.ToString());
                rapportElement.SetAttribute("Bilan", rapportItem.bilan.ToString());
                rapportElement.SetAttribute("Visiteur", rapportItem.idVisiteur.ToString());
                rapportElement.SetAttribute("Medecin", rapportItem.idMedecin.ToString());
                
                root.AppendChild(rapportElement);
            }

            string fileName = "rapports.xml";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, fileName);
            xmlDoc.Save(filePath);

            MessageBox.Show($"Le fichier XML des rapports a été généré avec succès dans {filePath}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
