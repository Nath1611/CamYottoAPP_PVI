using CamYottoAPP.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        UserViewModel Vm;

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = Vm = new UserViewModel();
        }

        private void CmdSeePass(object sender, ToggledEventArgs e)
        {

            if (SwSeePass.IsToggled)
            {
                TxtPassword.IsPassword = false;
            }
            else
            {
                TxtPassword.IsPassword = true;
            }

        }

        private async void CmdUserRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserRegisterPage());
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            /*bool r = await Vm.ValidateUserAccess(TxtUserName.Text.Trim(), TxtPassword.Text.Trim());

            if (r)
            {
                await DisplayAlert("Alerta Login", "Usuario Correcto", "OK");

                await Navigation.PushAsync(new ActionsPage());
            }
            else
            {
                await DisplayAlert("Alerta Login", "Usuario Incorrecto", "OK");
                TxtPassword.Focus();
            }*/

            await Navigation.PushAsync(new ActionsPage());
        }
    }
}