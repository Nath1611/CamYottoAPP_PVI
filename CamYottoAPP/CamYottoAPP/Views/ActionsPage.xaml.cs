using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CamYottoAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActionsPage : ContentPage
    {
        public ActionsPage()
        {
            InitializeComponent();
        }

        /*private async void BtnAddPedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyAddPedidoPage());
        }

        private async void BtnAddProducto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyAddProductoPage());
        }

        private async void BtnViewPedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewPedidosPage());
        }

        private async void BtnViewProducto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewProductosPage());
        }*/

        private async void BtnActionsProducto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsProductoPage());
        }

        private async void BtnActionsPedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsPedidoPage());
        }

        private async void BtnActionsCliente_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsClientePage());
        }

        private async void BtnActionsMaquinaria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsMaquinariaPage());
        }
    }
}