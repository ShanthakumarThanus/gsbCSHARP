using gsbRapports2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class Form1 : Form
    {
        private gsbrapportsEntities gsbEntities;
        public Form1()
        {
            this.InitializeComponent();
            this.gsbEntities = new gsbrapportsEntities();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmRapport f = new FrmRapport(this.gsbEntities);
            f.MdiParent = this;
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecherche r = new FrmRecherche(this.gsbEntities);
            r.MdiParent = this;
            r.Show();
        }
    }
}
