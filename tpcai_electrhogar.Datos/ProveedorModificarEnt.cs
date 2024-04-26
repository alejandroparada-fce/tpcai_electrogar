﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ProveedorModificarEnt
    {
        //Atributos
        private Guid _id;
        private Guid _idUsuario;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cuit;

        //Propiedades
        public Guid Id { get { return _id; } set { _id = value; } }
        public Guid IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string CUIT { get { return _cuit; } set { _cuit = value; } }
        
        
       


        //Constructor para todos los atributos
        public ProveedorModificarEnt(Guid id, Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            Id = id;
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email; 
            CUIT = cuit;
        }
    }
}