using System;
using System.Collections.Generic;
using System.Text;

namespace CamYottoAPP.Models
{
    public class Cama
    {
        public string Medidas { get; set; }
        public string DetallePers { get; set; }
        public string Colores { get; set; }
        public int Idcama { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
