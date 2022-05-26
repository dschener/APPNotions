using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OneSignalSDK.Xamarin;
using OneSignalSDK.Xamarin.Core;
using System.Collections.Generic;
using System.Net.Http;

namespace APPNotions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Plugin.Media.CrossMedia.Current.Initialize();

            MainPage = new NavigationPage(new MainPage());

            OneSignal.Default.Initialize(Config.oneSignalKey);
            OneSignal.Default.NotificationOpened += _notificationOpened;
            OneSignal.Default.NotificationWillShow += _notificationReceived;

            OneSignal.Default.SendTag("Lenguaje", "Xamarin");
            OneSignal.Default.SendTag("ambiente", Config.ambiente);
            OneSignal.Default.SendTag("modulo", Config.modulo);
            OneSignal.Default.SendTag("tokenUsuario", "Null");

            OneSignal.Default.PromptForPushNotificationsWithUserResponse();
        }


        private void _notificationOpened(NotificationOpenedResult result)
        {
            string launchURL = Config.urlLogin;
            Dictionary<string, object> additionalData = result.notification.additionalData;
            string accionId = "";
            string accionUrl = "";
            if (result.action.actionID != null)
            {
                accionId = result.action.actionID;
            }
            if (additionalData != null)
            {
                if (accionId != "")
                {
                    if (additionalData.ContainsKey(accionId))
                    {
                        launchURL = additionalData[accionId].ToString();
                        accionUrl = launchURL;
                    }
                }
                if (additionalData.ContainsKey("launchURL") && accionUrl == "")
                {
                    launchURL = additionalData["launchURL"].ToString();
                }
            }
            if (accionUrl.Contains("showAPP=false"))
            {
                HttpClient cliente = new HttpClient();
                cliente.GetAsync(accionUrl);
            }
            else
            {
                MainPage = new MainPage(launchURL);
            }
        }

        private Notification _notificationReceived(Notification notification)
        {
            //Response to Notification Received Event
            return notification; // show the notification
        }


        protected override void OnResume()
        {
            base.OnResume();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

    }
}
