﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;

namespace PersistenciaWS
{
    public static class ClienteService
    {
        public static List<ClienteEnt> ListarClientes(out string error)
        {
            string path = "/api/Cliente/GetClientes";
            List<ClienteEnt> listadoClientes = new List<ClienteEnt>();
            error = null;

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
                else
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    listadoClientes = JsonConvert.DeserializeObject<List<ClienteEnt>>(contentStream);
                    return listadoClientes;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return listadoClientes;

        }

        public static void AgregarCliente(ClienteAgregarEnt cliente, out String error)
        {
            String path = "​/api​/Cliente​/AgregarCliente";
            error = null;
            var jsonRequest = JsonConvert.SerializeObject(cliente);
            
            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);      
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

        }

        public static void AgregarCliente2(ClienteAgregarEnt altaCliente)
        {
            String path = "/api/Cliente/AgregarCliente";

            var jsonRequest = JsonConvert.SerializeObject(altaCliente);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    //Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                string error = $"Exception: {ex.Message}";
            }
        }
    }
}
