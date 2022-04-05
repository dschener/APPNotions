using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Com.OneSignal;
using Com.OneSignal.Core;


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
                OneSignal.Default.SendTag("tokenUsuario", "logout");
                Navegador.Source = Config.urlLogin;
            }
            if (e.Url.Contains("token"))
            {
                string token = e.Url.Split(new string[] { "token=" }, StringSplitOptions.None)[1];
                OneSignal.Default.SendTag("tokenUsuario", token);
            }
            if (e.Url.Contains("target=browser") || e.Url.StartsWith("tel:"))
            {
                try
                {
                    await Launcher.OpenAsync(new Uri(e.Url));
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        Navegador.GoBack();
                    }
                    else if (Device.RuntimePlatform == Device.Android)
                    {
                        e.Cancel = true;
                    }                    
                }
                catch
                {

                }
            }
        }
    }
}
