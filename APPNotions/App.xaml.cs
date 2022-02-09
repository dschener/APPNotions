using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Com.OneSignal;
using Com.OneSignal.Abstractions;
using System.Collections.Generic;

namespace APPNotions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //Remove this method to stop OneSignal Debugging  
            OneSignal.Current.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.NONE);

            OneSignal.Current.StartInit("f8a0c2c3-1256-4bf3-91b8-bec7e20f058f")
            .InFocusDisplaying(OSInFocusDisplayOption.Notification)
            .HandleNotificationOpened(OnHandleNotificationOpened)
            .Settings(new Dictionary<string, bool>() {
    { IOSSettings.kOSSettingsKeyAutoPrompt, false },
    { IOSSettings.kOSSettingsKeyInAppLaunchURL, false } })
            .InFocusDisplaying(OSInFocusDisplayOption.Notification)
            .EndInit();
            OneSignal.Current.SetExternalUserId(Config.ambiente + "_" + Config.modulo + "_" + Config.municipio + "_Null");
            OneSignal.Current.SendTag("Lenguaje", "Xamarin");
            OneSignal.Current.SendTag("ambiente", Config.ambiente);
            OneSignal.Current.SendTag("modulo", Config.modulo);
            OneSignal.Current.SendTag("municipio", Config.municipio);
            OneSignal.Current.SendTag("tokenUsuario", "Null");
            OneSignal.Current.RegisterForPushNotifications();


        }

        private void OnHandleNotificationOpened(OSNotificationOpenedResult result)
        {
            OSNotificationPayload payload = result.notification.payload;
            Dictionary<string, object> additionalData = payload.additionalData;
            string launchURL = null;
            if (additionalData != null)
            {
                if (additionalData.ContainsKey("launchURL"))
                {
                    launchURL = additionalData["launchURL"].ToString();
                }
            }
            MainPage = new MainPage(launchURL);
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
