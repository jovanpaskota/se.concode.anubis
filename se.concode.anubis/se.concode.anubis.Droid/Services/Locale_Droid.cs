using se.concode.anubis.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(se.concode.anubis.Droid.Services.Locale_Droid))]
namespace se.concode.anubis.Droid.Services
{
   public class Locale_Droid : ILocale
   {
      public string GetCurrent()
      {
         var androidLocale = Java.Util.Locale.Default;
         var netLanguage = androidLocale.ToString().Replace("_", "-");
         return netLanguage;
      }
   }
}