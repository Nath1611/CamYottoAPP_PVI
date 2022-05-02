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
    public partial class ActionsProductoPage : ContentPage
    {
        public ActionsProductoPage()
        {
            InitializeComponent();
        }

        private async void BtnAddProducto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyAddProductoPage());
        }

        private async void BtnViewProducto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewProductosPage());
        }
    }
}