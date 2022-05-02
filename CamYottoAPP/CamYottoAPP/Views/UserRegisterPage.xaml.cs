using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CamYottoAPP.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CamYottoAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserRegisterPage : ContentPage
    {
        UserViewModel viewModel;
        public UserRegisterPage()
        {
            InitializeComponent();

            //SE ANCLA LA VISTA CON EL VIEWMODEL RESPECTIVO 
            BindingContext = viewModel = new UserViewModel();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            bool R = await viewModel.AddUser(TxtUserId.Text.Trim(),
                                             TxtUserName.Text.Trim(),
                                             TxtPhone.Text.Trim(),
                                             TxtEmail.Text.Trim(),
                                             TxtUserPass.Text.Trim());
            if (R)
            {
                await DisplayAlert("¡Alerta!", "El usuario ya ha sido añadido!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("¡Alerta!", "Ocurrió un error!", "OK");
            }
        }

        private void CmdSeePass(object sender, ToggledEventArgs e)
        {
            if (SwSeePass.IsToggled)
            {
                TxtUserPass.IsPassword = false;
            }
            else
            {
                TxtUserPass.IsPassword = true;
            }
        }
    }
}