﻿using System;
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
    public partial class inviteNewEvents : Form
    {
        public inviteNewEvents()
        {
            InitializeComponent();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            formMain form = (formMain)ActiveForm;
            form.panelAllForm.Controls.Clear();
            formEvenements formEvenements = new formEvenements() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formEvenements.FormBorderStyle = FormBorderStyle.None;
            form.panelAllForm.Controls.Add(formEvenements);
            formEvenements.Show();
            form.lblNomForm.Text = "Créer de nouveaux évènements !";
            form.lblPresentationForm.Text = "";
        }
    }
}