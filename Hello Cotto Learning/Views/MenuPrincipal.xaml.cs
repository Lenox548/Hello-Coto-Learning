using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Cotto_Learning.Views
{
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            int usuario = 0;
            if (usuario == 0)
            {
                DisplayAlert("Introducción", "'Texto Introductorio, Terminos y condiciones'", "Aceptar");
            }
        }
    }
}