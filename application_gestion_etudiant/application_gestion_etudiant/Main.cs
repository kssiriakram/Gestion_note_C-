﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_lib;

namespace application_gestion_etudiant
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
             new Gestion_etudiants().Show();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_etudiants_Click(object sender, EventArgs e)
        {
            new Gestion_etudiants().Show();
        }

        private void Consultation_notes_Click(object sender, EventArgs e)
        {
            new Consultation_notes().Show();
        }

        private void bilanAnnuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bilan_annuel().Show();
        }
    }
}
