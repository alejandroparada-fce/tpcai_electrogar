﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpcai_electrhogar
{
    public partial class FormProveedorAlta : Form
    {
        public FormProveedorAlta()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            //Errores Comentados
            string mensajeError;
            //bool valido1 = Validaciones.ValidarCadena(textBoxNombre.Text, "'Nombre'", 3, 30, out string mensajeError1);
            //bool valido2 = Validaciones.ValidarCadena(textBoxApellido.Text, "'Apellido'", 3, 30, out string mensajeError2);
            //bool valido3 = Validaciones.ValidarEntero(textBoxCUIT.Text, "'CUIT'", 1000000, 100000000, out int DNI, out string mensajeError3);
            //bool valido4 = Validaciones.ValidarCadena(textBoxMail.Text, "'EMAIL", 3, 30, out string mensajeError4);

            //mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3 + "\n" + mensajeError4;

            //lblError.Text = mensajeError;
        }
    }
}
