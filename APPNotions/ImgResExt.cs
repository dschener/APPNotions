using System;
using System.Reflection;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
namespace APPNotions
{
    [ContentProperty(nameof(Source))]
    class ImgResExt : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {

            }
            var imageSource = ImageSource.FromResource(Source, typeof(ImgResExt).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}
