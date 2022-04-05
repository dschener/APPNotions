using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Com.OneSignal;
using Com.OneSignal.Core;
using System.Collections.Generic;

namespace APPNotions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            OneSignal.Default.Initialize(Config.oneSignalKey);
            OneSignal.Default.NotificationWasOpened += _notificationOpened;
            OneSignal.Default.NotificationWillShow += _notificationReceived;

            OneSignal.Default.SendTag("Lenguaje", "Xamarin");
            OneSignal.Default.SendTag("ambiente", Config.ambiente);
            OneSignal.Default.SendTag("modulo", Config.modulo);
            OneSignal.Default.SendTag("municipio", Config.municipio);
            OneSignal.Default.SendTag("tokenUsuario", "Null");
            // No disponible en v3
            //OneSignal.Default.RegisterForPushNotifications();
        }


        private void _notificationOpened(NotificationOpenedResult  result)
        {
            //string payload = result.notification.rawPayload;
            //Dictionary<string, object> additionalData = new Dictionary<string, object>();
            //additionalData.LoadFromXaml(result.notification.rawPayload);
            string launchURL = Config.urlLogin;

            //if (additionalData != null)
            //{
            //    if (additionalData.ContainsKey("launchURL"))
            //    {
            //        launchURL = additionalData["launchURL"].ToString();
            //    }
            //}
            MainPage = new MainPage(launchURL);
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
