using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using CamYottoAPP.Models;

namespace CamYottoAPP.ViewModels
{
    public class ProductoViewModel : BaseViewModel
    {
        public Producto MyProducto { get; set; }

        public ProductoViewModel()
        {
            MyProducto = new Producto();
        }

        public async Task<ObservableCollection<Producto[]>> GetQList()
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
                    ObservableCollection<Producto[]> list = new ObservableCollection<Producto[]>();

                    list = await MyProducto.GetProductoList();

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
