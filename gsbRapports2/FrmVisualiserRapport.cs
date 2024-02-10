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
    public partial class FrmVisualiserRapport : Form
    {
        private gsbrapportsEntities gsbEntities;
        public FrmVisualiserRapport(gsbrapportsEntities gsbEntities)
        {
            InitializeComponent();
            this.gsbEntities = gsbEntities;
            this.medecinBindingSource.DataSource = gsbEntities.medecins.ToList();
        }
    }
}
