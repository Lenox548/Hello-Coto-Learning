using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Cotto_Learning.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opciones : ContentPage
    {
        public Opciones()
        {
            InitializeComponent();
            
        }

        public void TemaClaro_On(object sender, ToggledEventArgs e)
        {
            if (TemaClaro.IsToggled == true)
            {
                TemaOscuro.IsToggled = false;
                App.Current.Resources["MainColor"] = Color.White;
                App.Current.Resources["SecondColor"] = Color.Black;
                App.Current.Resources["Background"] = Color.White;
                App.Current.Resources["PlaceholderColor"] = Color.FromHex("777777");
            }
            else {TemaOscuro.IsToggled = true;}
        }
        public void TemaOscuro_On(object sender, ToggledEventArgs e)
        {
            if (TemaOscuro.IsToggled == true)
            {
                TemaClaro.IsToggled = false;
                App.Current.Resources["MainColor"] = Color.Black;
                App.Current.Resources["SecondColor"] = Color.White;
                App.Current.Resources["Background"] = Color.FromHex("202020");
                App.Current.Resources["PlaceholderColor"] = Color.FromHex("5a5a5a");
            }
            else {TemaClaro.IsToggled = true;}
        }

        private void Musica_On(object sender, ToggledEventArgs e)
        {

        }
    }
}