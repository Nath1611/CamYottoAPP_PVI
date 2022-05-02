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
    public partial class ActionsPedidoPage : ContentPage
    {
        public ActionsPedidoPage()
        {
            InitializeComponent();
        }

        private async void BtnAddPedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyAddPedidoPage());
        }

        private async void BtnViewPedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewPedidosPage());
        }
    }
}