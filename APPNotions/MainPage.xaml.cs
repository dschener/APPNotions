using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Com.OneSignal;
using Com.OneSignal.Abstractions;


namespace APPNotions
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string url = null)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(url))
            {
                Navegador.Source = Config.urlLogin;
            }
            else
            {
                Navegador.Source = url;
            }
        }

        async void Navegador_Navigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.Contains("logout"))
            {
                OneSignal.Current.SendTag("tokenUsuario", "logout");
                Navegador.Source = Config.urlLogin;
            }
            if (e.Url.Contains("token"))
            {
                string token = e.Url.Split(new string[] { "token=" }, StringSplitOptions.None)[1];
                OneSignal.Current.SendTag("tokenUsuario", token);
                OneSignal.Current.SetExternalUserId(Config.ambiente + "_" + Config.modulo + "_" + Config.municipio + "_" + token);
            }
            if (e.Url.Contains("target=browser"))
            {
                try
                {
                    await Launcher.OpenAsync(new Uri(e.Url));
                    e.Cancel = true;
                }
                catch (Exception ex)
                {
                    Navegador.Source = "https://www.google.com/search?q=" + ex.Message;
                }
            }
        }
    }
}
