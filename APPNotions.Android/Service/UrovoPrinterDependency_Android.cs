using Android.App;
using Android.Content;
using Android.Device;
using Android.OS;
using Android.Print;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using APPNotions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(IUrovoPrinterDependency))]
namespace APPNotions.Droid.Service
{
    internal class UrovoPrinterDependency_Android : Java.Lang.Object, IUrovoPrinterDependency
    {
        public void print(string data)
        {
            PrinterManager printerManager = new PrinterManager();
            int ret = printerManager.Open();

            if (ret == 0)
            {
                int width = 384;
                int height = -1;
                int re = printerManager.SetupPage(width, height);
                if (re < 0)
                {
                    //setupPage failed
                }

                int x = 200;
                int y = 200;
                String fontName = "/system/fonts/kaishu.ttf"; 
                int fontSize = 8;
                int NO_ROTATE = 0;
                height = printerManager.DrawText(data, x, y, fontName, fontSize, false, false, NO_ROTATE);
                int status = printerManager.PrintPage(0);
            }
        }
    }
}