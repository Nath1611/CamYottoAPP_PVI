using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using System.Net;

namespace CamYottoAPP.Models
{
    public class Usuario
    {
        public RestRequest request { get; set; }

        string mimetype = "application/json";
        const string contentype = "Content-Type";

        public Usuario()
        {
            Clientes = new HashSet<Cliente>();
            Maquinaria = new HashSet<Maquinarium>();
            Pedidos = new HashSet<Pedido>();
            Productos = new HashSet<Producto>();

            request = new RestRequest();
        }

        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Contrasenna { get; set; }
       // public int Cedula { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Maquinarium> Maquinaria { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }


        public async Task<bool> AddNewUser()
        {

            bool r = false;

            try
            {
                //SE ADJUNTA A LA URL BASE LA DIRECCION DEL RECURSO QUE SE QUIERE CONSUMIR 
                string FinalApiRoute = CnnToAPI.ProductionRoute + "users";

                RestClient client = new RestClient(FinalApiRoute);

                request = new RestRequest(FinalApiRoute, Method.Post);


                //AGREGAR LA INFRO DE SEGURIDAD, EN ESTE CASI API KEY
                request.AddHeader(CnnToAPI.APIKeyName, CnnToAPI.APIKeyValue);
                request.AddHeader(contentype, mimetype);

                //SERIALIZAR ESTA CLASE PARA PASARLA EN EL BODY
                string SerializedClass = JsonConvert.SerializeObject(this);

                request.AddBody(SerializedClass, mimetype);

                //ESTO ENVÍA LA CONSULTA AL API Y SE RECIBE UNA RESPUESTA QUE DEBEMOS LEER
                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.Created)
                {
                    r = true;
                }

            }
            catch (Exception ex)
            {

                string msg = ex.Message;

                throw;
            }

            return r;
        }

        //FUNCION PARA VALIDAR EL ACCESO DEL USUARIO EN EL SISTEMA
        public async Task<bool> ValidateUserAccess()
        {
            bool r = false;

            try
            {
                //COMO ESTA RUTA ES UN POCO MÁS COMPLEJA DE CONSUMIR YA QUE LLEVA UNA FUNCIÓN CON NOMBRE
                //Y DOS PARÁMETROS, LO MÁS CONVENIENTE ES FORMATEARLA POR APARTE Y LUEGO ADJUNTARLA  A
                //BASE URL(CnnToAPI.ProductionRoute) PARA OBTENER LA RUTA COMPLETA
                string routeSufix = string.Format("Users/ValidateUserLogin?pUserId={0}&pPassword={1}", this.Idusuario, this.Contrasenna);

                string FinalApiRoute = CnnToAPI.ProductionRoute + routeSufix;

                RestClient client = new RestClient(FinalApiRoute);

                request = new RestRequest(FinalApiRoute, Method.Get);

                //AGREGAR LA INFRO DE SEGURIDAD, EN ESTE CASI API KEY
                request.AddHeader(CnnToAPI.APIKeyName, CnnToAPI.APIKeyValue);
                request.AddHeader(contentype, mimetype);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    r = true;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw;
            }

            return r;
        }


    }
}
