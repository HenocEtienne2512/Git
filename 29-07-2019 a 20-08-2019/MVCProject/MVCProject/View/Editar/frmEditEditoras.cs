﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar {
    public partial class frmEditEditoras : Form {
        public frmEditEditoras() {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow EditorasRow;

        private void BtSave_Click(object sender, EventArgs e) {
            EditorasRow.Nome = txtNome.Text;
            EditorasRow.Decricao = txtDesc.Text;

            this.Close();
        }
    }
}
