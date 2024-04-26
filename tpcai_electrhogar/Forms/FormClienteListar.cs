﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Datos;
using tpcai_electrhogar.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tpcai_electrhogar
{
    public partial class FormClienteListar : Form
    {
        public FormClienteListar()
        {
            InitializeComponent();
        }
        private string mensajeError;

        private void ListadoClientesForm_Load(object sender, EventArgs e)
        {
            //dgvClientes.DataSource = ModuloClientes.ConsultarClientes(out string error);
            List<ClienteEnt> listaClientes = ModuloClientes.ConsultarClientes(out string error);


            /*foreach (ClienteEnt c in listaClientes)
            {
                int rowIndex = dgvClientes.Rows.Add();
                DataGridViewRow row = dgvClientes.Rows[rowIndex];
                row.Cells[0].Value = c.id;
                row.Cells[1].Value = c.nombre;
                row.Cells[2].Value = c.apellido;
                row.Cells[3].Value = c.dni;
                row.Cells[4].Value = c.direccion;
                row.Cells[5].Value = c.telefono;
                row.Cells[6].Value = c.email;
                row.Cells[7].Value = c.fechaNacimiento;
                row.Cells[8].Value = c.fechaAlta;
                row.Cells[9].Value = c.fechaBaja;
                row.Cells[10].Value = c.host;

            }*/
            var bindingList = new BindingList<ClienteEnt>(listaClientes);
            var source = new BindingSource(bindingList, null);
            dgvClientes.DataSource = source;
            dgvClientes.Columns["id"].Visible = false;
            dgvClientes.Columns["fechaBaja"].Visible = false;
            dgvClientes.Columns[0].HeaderText = "Nombre";
            dgvClientes.Columns[1].HeaderText = "Apellido";
            dgvClientes.Columns[2].HeaderText = "Fecha de Alta";
            dgvClientes.Columns[3].HeaderText = "Fecha de Nacimiento";
            dgvClientes.Columns[5].HeaderText = "Host";
            dgvClientes.Columns[6].HeaderText = "DNI";
            dgvClientes.Columns[8].HeaderText = "Dirección";
            dgvClientes.Columns[9].HeaderText = "Teléfono";
            dgvClientes.Columns[10].HeaderText = "Email";

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteEnt clienteSeleccionado = (ClienteEnt)dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;
            direccionCambio.Text = clienteSeleccionado.direccion;
            telefonoCambio.Text = clienteSeleccionado.telefono;
            emailCambio.Text = clienteSeleccionado.email;
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ClienteEnt clienteSeleccionado = (ClienteEnt)dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;

            Guid id = clienteSeleccionado.id;
            String direccion = direccionCambio.Text;
            String telefono = telefonoCambio.Text;
            String email = emailCambio.Text;
            bool valido1 = Validaciones.ValidarCadena(direccionCambio.Text, "'Dirección'", 3, 30, out string mensajeError1);
            bool valido2 = Validaciones.ValidarCadena(telefonoCambio.Text, "'Teléfono'", 3, 30, out string mensajeError2);
            bool valido3 = Validaciones.ValidarCadena(emailCambio.Text, "'Correo Electrónico'", 3, 30, out string mensajeError3);
            mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3;
            lblError.Text = mensajeError;

            if (valido1 & valido2 & valido3)
            {
                try
                {
                    ModuloClientes.ModificarCliente(id, direccion, telefono, email, out string error);
                    this.Hide();
                    FormClienteListar listadoClientesForm = new FormClienteListar();
                    listadoClientesForm.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnCancelarContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal();
            modulosForm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteEnt clienteseleccionado = (ClienteEnt)dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;
            Guid id = clienteseleccionado.id;

                FormConfirmacion formConfirmacion = new FormConfirmacion(id);
                formConfirmacion.ShowDialog();
                this.Hide();
                FormClienteListar listadoClientesForm = new FormClienteListar();
                listadoClientesForm.Show();


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            FormUtils.MinimizarFormulario(this);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            FormUtils.MaximizarFormulario(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormUtils.SalirAplicacion();
        }

        private void FormClienteListar_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }
    }
    }
