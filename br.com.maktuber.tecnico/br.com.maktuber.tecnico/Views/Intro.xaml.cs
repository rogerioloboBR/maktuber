using br.com.maktuber.tecnico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace br.com.maktuber.tecnico.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Intro : ContentPage
    {
        public List<CarouselData> MyDataSource { get; set; }
        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }

        public Intro()
        {
            InitializeComponent();

            logoLayout.BackgroundColor = new Color(0, 0, 0, 0.7);

            MyDataSource = new List<CarouselData>() { new CarouselData() { Title = "Bem - Vindo", Detail="Ao Maktuber" }};

            BindingContext = this;

        }

        private async void Btn_Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void Btn_Registro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroPage());
        }
    }
}