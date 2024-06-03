﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;
using System.Net.Http;

namespace tpcai_electrhogar.Negocio
{
    public static class ModuloProveedor
    {
        public static Guid idUsuario = new Guid("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        public static Guid idProveedor = new Guid("8fc1b7c9-a59b-46b2-af97-1ac9d9b48773");

        public static List<ProveedorEnt> ProveedorListar(out string error)
        {
            List<ProveedorEnt> proveedorListar = new List<ProveedorEnt>();
            proveedorListar = ServiceProveedor.ProveedorListar(out error);
            return proveedorListar;
        }

        public static void ProveedorBaja(Guid idUsuario, Guid idProveedor, out string error)
        {
            ServiceProveedor.ProveedorBaja(idUsuario, idProveedor, out error);
        }

        public static void ProveedorAgregar(string id, string nombre, string apellido, string email,  string cuit, out string error)
        {
            ProveedorAgregarEnt proveedor = new ProveedorAgregarEnt(id, nombre, apellido, email, cuit);
            error = null;

            ServiceProveedor.ProveedorAgregar(proveedor, out error);
        }

        public static void ProveedorReactivar(Guid idUsuario,Guid idProveedor, out string error)
        {
            ServiceProveedor.ProveedorReactivar(idUsuario, idProveedor, out error);
        }

        public static void ProveedorModificar(Guid id, Guid idProveedor, string nombre, string apellido, string email, string cuit, out string error)
        {
            ServiceProveedor.ProveedorModificar(id, idProveedor, nombre, apellido, email, cuit, out error);
        }
    }

}
