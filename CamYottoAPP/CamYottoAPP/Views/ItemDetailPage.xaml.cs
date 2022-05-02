using CamYottoAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CamYottoAPP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}