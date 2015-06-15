using AndroidHUD;
using se.concode.anubis.Droid.Services.UI;
using se.concode.anubis.Services.UI;
using Xamarin.Forms;

[assembly: Dependency(typeof(LoadingService))]
namespace se.concode.anubis.Droid.Services.UI
{
   public class LoadingService : ILoadingService
   {
      #region ILoadingService implementation

      public void Show(string message = "Laddar")
      {
         Device.BeginInvokeOnMainThread(() => AndHUD.Shared.Show(Forms.Context, maskType: MaskType.Black));
      }

      public void Hide()
      {
         Device.BeginInvokeOnMainThread(() => AndHUD.Shared.Dismiss(Forms.Context));
      }

      #endregion
   }
}