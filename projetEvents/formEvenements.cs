using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace projetEvents
{
    public partial class formEvenements : Form
    {
        private DataSet ds;

        public formEvenements()
        {
            InitializeComponent();
            //ds = formMain.transfertDataSet;
        }

        private void formEvenements_Load(object sender, EventArgs e)
        {

        }
    }
}
