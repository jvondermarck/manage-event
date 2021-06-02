﻿using System;
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
    public partial class formBilan : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        // gdi32.dll contient des fonctions pour Windows GDI (Interface de périphérique graphique)
        // qui aide les fenêtres en créant les objets à deux dimensions simples.

        //La fonction CreateRoundRectRgn crée une région rectangulaire avec des coins arrondis.
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // coordonnée x du coin supérieur gauche
            int nTopRect, // coordonnée y du coin supérieur gauche
            int nRightRect, // coordonnée x du coin inférieur droit
            int nBottomRect, // coordonnée y du coin inférieur droit
            int nWidthEllipse, // hauteur de l'ellipse
            int nHeightEllipse // largeur de l'ellipse
        );


        public formBilan()
        {
            InitializeComponent();
        }


        private void btnBilanGlobal_Click(object sender, EventArgs e)
        {

        }

        private void cboEvent_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
