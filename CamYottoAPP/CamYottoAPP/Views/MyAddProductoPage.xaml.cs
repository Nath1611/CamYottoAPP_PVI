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
    public partial class MyAddProductoPage : ContentPage
    {
        ProductoViewModel productoViewModel;
        public MyAddProductoPage()
        {
            InitializeComponent();

            BindingContext = productoViewModel = new ProductoViewModel();

            LoadList();
        }

        private async void LoadList()
        {
            
        }
    }
}