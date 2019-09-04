using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI.Dialogs;

namespace br.com.maktuber.tecnico.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Btn_LoginClicked(object sender, EventArgs e)
        {
            await MaterialDialog.Instance.AlertAsync(message: "Login realizado com sucesso.", title: "Sucesso",
                acknowledgementText: "Ok");
            await Task.Delay(1200);

            await Navigation.PushAsync(new MainPage());
        }
    }
}