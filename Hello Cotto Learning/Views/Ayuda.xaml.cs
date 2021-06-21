using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Cotto_Learning.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ayuda : ContentPage
    {
        public Ayuda()
        {
            InitializeComponent();
        }
        public void ReporteEnviado(object sender, EventArgs e)
        {
            CajaReporte.Text = string.Empty;
            DisplayAlert("Muchas Gracias", "Tus comentarios nos ayudan a mejorar Hello Cotto Learning", "Continuar");
        }
    }
}