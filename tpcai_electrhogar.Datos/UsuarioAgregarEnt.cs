﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class UsuarioAgregarEnt
    {
        private Guid _idUsuario;
        private int _host;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaNacimiento;
        private string _nombreUsuario;
        private string _contraseña;

        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int host { get => _host; set => _host = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public int dni { get => _dni; set => _dni = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string email { get => _email; set => _email = value; }
        public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string nombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string contraseña { get => _contraseña; set => _contraseña = value; }

        public UsuarioAgregarEnt(Guid idUsuario, int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            this.idUsuario = idUsuario;
            this.host = host;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
    }
}
