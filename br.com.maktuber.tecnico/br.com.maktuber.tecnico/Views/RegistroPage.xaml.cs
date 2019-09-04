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
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        private async void NewUser_Clided(object sender, EventArgs e)
        {
            await MaterialDialog.Instance.AlertAsync(message: "Cadastro realizado com sucesso. Termine de preencher o seu perfil", title:"Sucesso",
                acknowledgementText:"Pra já");
            await Task.Delay(1200);
            
            await Navigation.PushAsync(new MainPage());
            

        }
    }
}