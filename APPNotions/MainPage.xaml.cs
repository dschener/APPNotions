using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using OneSignalSDK.Xamarin;
using OneSignalSDK.Xamarin.Core;
using System.Net.Http;
using System.Net;
using System.IO;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;

namespace APPNotions
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private DeviceFeaturesHelper _deviceFeaturesHelper;
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
            //Navegador.RegisterAction(ExecuteActionFromJavascript);

            _deviceFeaturesHelper = new DeviceFeaturesHelper();

        }
        void OnBack(object sender, EventArgs args)
        {
            Navegador.GoBack();
        }

        protected override bool OnBackButtonPressed()
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
                return true;
            }
            else return base.OnBackButtonPressed();
        }

        async void Navegador_Navigating(object sender, WebNavigatingEventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                // Bandera que me sirve para identificar si debo redireccionar al cliente al final, o esperar un async
                string UrlNavegacion = e.Url;
                bool isTargetBrowser = UrlNavegacion.Contains("target=browser");
                bool isTargetBack = UrlNavegacion.Contains("target=back");
                bool isTel = UrlNavegacion.StartsWith("tel:");
                bool isAsyncTask = UrlNavegacion.Contains("asyncTask=");
                bool isWebDominio = UrlNavegacion.Contains(Config.dominio);
                bool isCoordenadas = UrlNavegacion.Contains("Coordenadas=Coordenadas");
                bool isFoto = UrlNavegacion.Contains("action=PHOTO");

                NavigationPage.SetHasNavigationBar(this, !isWebDominio || isTargetBack);
                #region Push OneSignal
                if (UrlNavegacion.Contains("token"))
                {
                    string token = GetValueAndRemoveFromQueryStringByKey(ref UrlNavegacion, "token");
                    await OneSignal.Default.SendTag("tokenUsuario", token);
                }
                if (UrlNavegacion.Contains("logout"))
                {
                    await OneSignal.Default.SendTag("tokenUsuario", "logout");
                    Navegador.Source = Config.urlLogin;
                }
                #endregion
                #region Si tiene algún parametro que altere la navegación, entra al if. Sino sale y navega normalmente
                if (isAsyncTask || isTargetBrowser || isCoordenadas)
                {
                    if (isAsyncTask)
                    {
                        string urlAsync = GetValueAndRemoveFromQueryStringByKey(ref UrlNavegacion, "asyncTask");
                        // Es redundante cancelar la navegación acá, pero sino no funciona...
                        if (Device.RuntimePlatform == Device.iOS)
                        {
                            Navegador.GoBack();
                        }
                        else if (Device.RuntimePlatform == Device.Android)
                        {
                            e.Cancel = true;
                        }
                        DispararTaskAsyn(System.Web.HttpUtility.UrlDecode(urlAsync));
                        //Navegador.Source = UrlNavegacion;
                    }
                    if (isCoordenadas && !isTel)
                    {
                        if (Device.RuntimePlatform == Device.iOS)
                        {
                            Navegador.GoBack();
                        }
                        else if (Device.RuntimePlatform == Device.Android)
                        {
                            e.Cancel = true;
                        }
                        //if (!isTargetBrowser)
                        //{
                        //    var browser = new WebView();
                        //    var htmlSource = new HtmlWebViewSource();
                        //    htmlSource.Html = GetHTMLCalculandoPosicion();
                        //    Navegador.Source = htmlSource;
                        //}
                        await RedireccionConCoordenadasExactas(UrlNavegacion, isTargetBrowser);
                    }
                    if (isTargetBrowser && !isCoordenadas)
                    {
                        NavigationPage.SetHasNavigationBar(this, false);
                        if (Device.RuntimePlatform == Device.iOS)
                        {
                            Navegador.GoBack();
                        }
                        else if (Device.RuntimePlatform == Device.Android)
                        {
                            e.Cancel = true;
                        }
                        try
                        {
                            await Launcher.OpenAsync(new Uri(UrlNavegacion));
                        }
                        catch
                        {

                        }
                    }
                    if (isTel)
                    {
                        NavigationPage.SetHasNavigationBar(this, false);
                        if (Device.RuntimePlatform == Device.iOS)
                        {
                            Navegador.GoBack();
                        }
                        else if (Device.RuntimePlatform == Device.Android)
                        {
                            e.Cancel = true;
                        }
                        try
                        {
                            bool permisosConcedidos = await _deviceFeaturesHelper.CheckForPhonePermission();
                            if (permisosConcedidos)
                            {
                                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                                if (phoneDialer.CanMakePhoneCall)
                                    phoneDialer.MakePhoneCall(UrlNavegacion.Replace("tel:", "+"));
                            }
                            else
                            {
                                await Launcher.OpenAsync(new Uri(UrlNavegacion));
                            }
                        }
                        catch
                        {

                        }
                    }
                    // Si es tel y cambio, es porque al link le saque el async.
                    if (UrlNavegacion != e.Url && !isTel)
                    {
                        // Redirijo a la nueva url (donde elimine los asyncTask, y se dispara nuevamente este método)
                        Navegador.Source = UrlNavegacion;
                    }
                    #endregion
                }
                else
                {
                    if (isTel)
                    {
                        NavigationPage.SetHasNavigationBar(this, false);
                        if (Device.RuntimePlatform == Device.iOS)
                        {
                            Navegador.GoBack();
                        }
                        else if (Device.RuntimePlatform == Device.Android)
                        {
                            e.Cancel = true;
                        }
                        try
                        {
                            bool permisosConcedidos = await _deviceFeaturesHelper.CheckForPhonePermission();
                            if (permisosConcedidos)
                            {
                                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                                if (phoneDialer.CanMakePhoneCall)
                                    phoneDialer.MakePhoneCall(UrlNavegacion.Replace("tel:", "+"));
                            }
                            else
                            {
                                await Launcher.OpenAsync(new Uri(UrlNavegacion));
                            }
                        }
                        catch
                        {

                        }
                    }
                    if (isFoto)
                    {
                        NavigationPage.SetHasNavigationBar(this, false);
                        if (Device.RuntimePlatform == Device.iOS)
                        {
                            Navegador.GoBack();
                        }
                        else if (Device.RuntimePlatform == Device.Android)
                        {
                            e.Cancel = true;
                        }
                        try
                        {
                            ExecuteActionFromJavascript("PHOTO", GetValueAndRemoveFromQueryStringByKey(ref UrlNavegacion, "destino"));
                        }
                        catch
                        {

                        }
                    }
                }
            }
            else
            {
                var browser = new WebView();
                var htmlSource = new HtmlWebViewSource();
                htmlSource.Html = GetHTMLSinConexion();
                Navegador.Source = htmlSource;
            }
        }
        public string GetHTMLSinConexion()
        {
            return "<html><body><div style=\"background-color: #333399; width: 100%;color: #FFF; width: 100%;\"><h1>Sin Internet</h1></div>"
                + "<p>El dispositivo se ha quedado sin internet. Aguarda unos minutos e intenta nuevamente.</p>"
                + "<p>Click <a href=\"" + Config.urlLogin + "\" style=\"background-color: #2b23FF; color: #fff; display: inline-block; padding: 3px 10px; font-weight: bold; border-radius: 5px;\">aquí</a> para reintentar</p></body></html>";
        }
        public string GetHTMLCalculandoPosicion()
        {
            return "<html><body><div style=\"background-color: #333399; width: 100%;color: #FFF; width: 100%;\"><h1>Obteniendo posición GPS</h1></div>"
                + "<p>Buscando posición GPS...</p>"
                + "<p>Aguarde unos segundos, y será rediriguido automáticamente...</p></body></html>";
        }

        public async Task RedireccionConCoordenadasExactas(string urlOriginal, bool AbrirEnVentanaNueva)
        {
            EsperandoGPS.IsVisible = true;
            Navegador.IsVisible = false;
            var Latitude = double.Parse("0");
            var Longitude = double.Parse("0");
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Best);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Latitude = location.Latitude;
                    Longitude = location.Longitude;
                }
            }
            catch { }
            string url = urlOriginal.Replace("Coordenadas=Coordenadas", "Latitud=" + Latitude.ToString().Replace(",", ".") + "&Longitud=" + Longitude.ToString().Replace(",", "."));
            EsperandoGPS.IsVisible = false;
            Navegador.IsVisible = true;
            if (AbrirEnVentanaNueva)
            {
                Launcher.OpenAsync(new Uri(url));
            }
            else
            {
                Navegador.Source = url;
            }
        }

        public async Task DispararTaskAsyn(string urlOriginal)
        {
            var Latitude = double.Parse("0");
            var Longitude = double.Parse("0");
            if (urlOriginal.Contains("Coordenadas=Coordenadas"))
            {
                try
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Best);
                    var location = await Geolocation.GetLocationAsync(request);

                    if (location != null)
                    {
                        Latitude = location.Latitude;
                        Longitude = location.Longitude;
                    }
                }
                catch { }

            }
            urlOriginal = urlOriginal.Replace("Coordenadas=Coordenadas", "Latitud=" + Latitude.ToString().Replace(", ", ".") + "&Longitud=" + Longitude.ToString());
            HttpClient cliente = new HttpClient();
            cliente.GetAsync(urlOriginal);
        }

        public string GetValueAndRemoveFromQueryStringByKey(ref string url, string key)
        {
            var uri = new Uri(url);
            string valor;
            var newQueryString = HttpUtility.ParseQueryString(uri.Query);
            valor = newQueryString.Get(key);
            newQueryString.Remove(key);

            // this gets the page path from root without QueryString
            string pagePathWithoutQueryString = uri.GetLeftPart(UriPartial.Path);

            url = newQueryString.Count > 0
                ? String.Format("{0}?{1}", pagePathWithoutQueryString, newQueryString)
                : pagePathWithoutQueryString;
            return valor;
        }

        private async void ExecuteActionFromJavascript(string param1, string param2)
        {
            if (param1 != null && param1.Equals("PHOTO"))
            {
                var result = await _deviceFeaturesHelper.TakePhoto(this);
                if (result != null)
                {
                    //await Navegador.EvaluateJavaScriptAsync($"setresult_takephoto('{result}')");
                    await Navegador.EvaluateJavaScriptAsync("document.getElementById('" + param2 + "').value='" + result + "';");
                    await Navegador.EvaluateJavaScriptAsync("document.getElementById('" + param2 + "Img').src='data:image/png;base64," + result + "';");
                }
            }
        }

    }
}
