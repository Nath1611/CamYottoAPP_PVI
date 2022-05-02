using System;
using System.Collections.Generic;
using System.Text;

namespace CamYottoAPP.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int Idcliente { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int UsuarioIdusuario { get; set; }

        public virtual Usuario UsuarioIdusuarioNavigation { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
