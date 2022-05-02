using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace CamYottoAPP.Models
{
    public class Producto
    {
        public RestRequest request { get; set; }

        string mimetype = "application/json";
        const string contentype = "Content-Type";


        public int Valor { get; set; }
        public string Detalle { get; set; }
        public int Idproducto { get; set; }
        public int? IdtipoProdcto { get; set; }
        public int UsuarioIdusuario { get; set; }

        public virtual Pedido Idproducto1 { get; set; }
        public virtual Cama Idproducto2 { get; set; }
        public virtual Chaleco IdproductoNavigation { get; set; }
        public virtual Usuario UsuarioIdusuarioNavigation { get; set; }


        //ESTA FUNCION LLAMA A LA RUTA ("GetQuestionsListByUserID") QUE RETORNA UN JSON
        //QUE LUEGO SE DEBE CONVERTIR A CLASE (MODELO) ASK.
        public async Task<ObservableCollection<Producto[]>> GetProductoList()
        {

            try
            {
                //COMO ESTA RUTA ES UN POCO MÁS COMPLEJA DE CONSUMIR YA QUE LLEVA UNA FUNCIÓN CON NOMBRE
                //Y DOS PARÁMETROS, LO MÁS CONVENIENTE ES FORMATEARLA POR APARTE Y LUEGO ADJUNTARLA  A
                //BASE URL(CnnToAPI.ProductionRoute) PARA OBTENER LA RUTA COMPLETA

                string routeSufix = string.Format("Producto/GetProductoList?pProductoId={0}", this.Idproducto);

                string FinalApiRoute = CnnToAPI.ProductionRoute + routeSufix;

                RestClient client = new RestClient(FinalApiRoute);

                request = new RestRequest(FinalApiRoute, Method.Get);


                //AGREGAR LA INFRO DE SEGURIDAD, EN ESTE CASI API KEY
                request.AddHeader(CnnToAPI.APIKeyName, CnnToAPI.APIKeyValue);
                request.AddHeader(contentype, mimetype);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                var QList = JsonConvert.DeserializeObject<ObservableCollection<Pedido>>(response.Content); ;

                if (statusCode == HttpStatusCode.OK)
                {
                    return null; //DA ERROR RETORNAR QLIST
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw;
            }

        }
    }
}
