using aplicacionPostres.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicacionPostres
{
    public partial class App : Application
    {
        private static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                    Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "postrecitos.db3"));//Se inicializa la base de datos, y se le asigana el nombre postrecitos 
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent(); //Realización de la nevegación entre páginas

            MainPage = new NavigationPage(new MainPage()); 
            //Indicación en todas las paginas
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
