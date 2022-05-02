using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using CamYottoAPP.Models;

namespace CamYottoAPP.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public Pedido MyPedido { get; set; }

        public PedidoViewModel()
        {
            MyPedido = new Pedido();
        }

        public async Task<ObservableCollection<Pedido[]>> GetQList()
        {

            if (IsBusy)
            {
                return null;
            }
            else
            {
                IsBusy = true;

                try
                {
                    ObservableCollection<Pedido[]> list = new ObservableCollection<Pedido[]>();

                    list = await MyPedido.GetQuestionListByUser();

                    if (list == null)
                    {
                        return null;
                    }
                    else
                    {
                        return list;
                    }

                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }
    }
}
