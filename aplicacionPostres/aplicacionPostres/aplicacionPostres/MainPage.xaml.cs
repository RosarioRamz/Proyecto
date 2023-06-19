using aplicacionPostres.Model;
using aplicacionPostres.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aplicacionPostres
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent(); 
            this.btnMenu.Clicked += onMenu; //Se manda a llamar un método desde un botón
            this.btnRegistro.Clicked += onRegistro;

        }
        //Método para mostrar las opciones del botón menú
        public async void onMenu(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new principal());
        }
        //Método para mostrar las opciones del botón Registro
        public async void onRegistro(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new formulario()); //Enviar a pagina de postres
        }
    }
}
