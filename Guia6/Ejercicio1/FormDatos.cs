﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            tbCUIT.Enabled = rbFisica.Checked == false;
        }
    }
}
