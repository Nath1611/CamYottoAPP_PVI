using System;
using System.Collections.Generic;
using System.Text;

namespace CamYottoAPP
{
    public static class CnnToAPI
    {
        //EN ESTA CLASE ESTATICA SE ALMACENA LA INFO DE ONFIGURACION DE CONSUMO DEL API
        //EN PRUEBAS NORMALMENTE SE USA UNA RUTA DISTINTA QUE EN PRODUCCION 

        public static string ProductionRoute = "http://192.168.0.10:45455/api/"; //cambiar

        public static string TestingRoute = "http://192.168.0.10:45455/api/"; //cambiar

     

        //EL API KEY ACA ES UTIL YA QUE EL USUARIO ANTES DE REGISTRARSE PODRIA USARLO, Y YA UNA VEZ REGISTRADO PUEDE USAR JWT

        public const string APIKeyName = "ApiKey";
        public static string APIKeyValue = "qwerty1316YOTTO";
    }
}
