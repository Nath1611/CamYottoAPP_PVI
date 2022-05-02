using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CamYottoAPP.ViewModels;

using System.Collections;
using System.Collections.ObjectModel;
using CamYottoAPP.Models;

namespace CamYottoAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAddPedidoPage : ContentPage
    {
        PedidoViewModel pedidoViewModel;

        public MyAddPedidoPage()
        {
            InitializeComponent();

            BindingContext = pedidoViewModel = new PedidoViewModel();

            LoadList();
        }

        private async void LoadList()
        {
            
        }

        
    }
}