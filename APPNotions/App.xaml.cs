using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Com.OneSignal;
using Com.OneSignal.Core;

namespace APPNotions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //Remove this method to stop OneSignal Debugging  
            //OneSignal.Default.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.NONE);

            //OneSignal v4
            OneSignal.Default.Initialize("f8a0c2c3-1256-4bf3-91b8-bec7e20f058f");
            OneSignal.Default.NotificationWasOpened += _notificationOpened;

            OneSignal.Default.NotificationWillShow += _notificationReceived;

            // OneSignal v3
            //        OneSignal.DefOneSignal.Default.Initialize("f8a0c2c3-1256-4bf3-91b8-bec7e20f058f");ault.StartInit(Config.oneSignalKey)
            //        .InFocusDisplaying(OSInFocusDisplayOption.Notification)
            //        .HandleNotificationOpened(OnHandleNotificationOpened)
            //        .Settings(new Dictionary<string, bool>() {
            //{ IOSSettings.kOSSettingsKeyAutoPrompt, false },
            //{ IOSSettings.kOSSettingsKeyInAppLaunchURL, false } })
            //        .InFocusDisplaying(OSInFocusDisplayOption.Notification)
            //        .EndInit();

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
            //Dictionary<string, object> additionalData = result.notification.rawPayload;
            string launchURL = Config.urlLogin;// null;
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
