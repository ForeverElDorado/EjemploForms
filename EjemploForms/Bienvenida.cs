﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
        private void botonEmpezar(object sender, EventArgs e)
        {
            //oculto en esta centana
            this.Hide();

            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();

        }
    }
}
