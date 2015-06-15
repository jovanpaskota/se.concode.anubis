
using Xamarin.Forms;

namespace se.concode.anubis
{
   public class App : Application, ILoginManager
   {
      NavigationPage _mainPage;
      public App()
      {
         _mainPage = new NavigationPage(new ServersPage())
         {
            BarBackgroundColor = Color.FromHex("000000"),
            BarTextColor = Color.White,
         };

         // we remember if they're logged in, 
         // and only display the login page if they're not
         if (!string.IsNullOrEmpty(Settings.Ticket))
         {
            MainPage = _mainPage;
         }
         else
         {
            MainPage = new LoginModalPage(this);
         }
      }

      public void ShowMainPage()
      {
         MainPage = _mainPage;
      }

      public void Logout()
      {
         Settings.Ticket = string.Empty;
         MainPage = new LoginModalPage(this);
      }

   protected override void OnStart()
      {
         // Handle when your app starts
      }

      protected override void OnSleep()
      {
         // Handle when your app sleeps
      }

      protected override void OnResume()
      {
         // Handle when your app resumes
      }
   }
}
