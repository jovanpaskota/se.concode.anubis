using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;

namespace se.concode.anubis.Services
{
   public class L10n
   {
      public L10n()
      {
      }

      /// <remarks>
      /// Maybe we can cache this info rather than querying every time
      /// </remarks>
      public static string Locale()
      {
         return DependencyService.Get<ILocale>().GetCurrent();
      }

      public static string Localize(string key, string comment)
      {
         var netLanguage = Locale();

         var temp = new ResourceManager("se.concode.anubis.Resx.AppResources", typeof(L10n).GetTypeInfo().Assembly);

         var result = temp.GetString(key, new CultureInfo(netLanguage));

         return result;
      }
   }
}