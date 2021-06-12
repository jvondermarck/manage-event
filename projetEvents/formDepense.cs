using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetEvents
{
    public partial class formDepense : Form
    {
        /*
         * Réalisé par Jad MACHKOUR
         * 
        */

        public formDepense()
        {
            InitializeComponent();
        }

        private void formDepense_Load(object sender, EventArgs e)
        {
            lblNbDepenses.Focus(); // On met le titre comme focus au depart pour éviter que la cbo aie un background bleu vu qu'il le sélectionné en premier

        }
    }
}
