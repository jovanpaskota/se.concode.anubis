using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigTed;
using Foundation;
using se.concode.anubis.iOS.Services.UI;
using se.concode.anubis.Services.UI;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(LoadingService))]
namespace se.concode.anubis.iOS.Services.UI
{
   public class LoadingService : ILoadingService
   {
      #region ILoadingService implementation

      public void Show(string message = "Laddar")
      {
         BTProgressHUD.Show(maskType: ProgressHUD.MaskType.Gradient);
      }

      public void Hide()
      {
         BTProgressHUD.Dismiss();
      }

      #endregion
   }
}