using Xamarin.Forms;

namespace se.concode.anubis.Views
{
   public class LoginModalPage : CarouselPage
   {
      readonly ContentPage login;

      public LoginModalPage(ILoginManager ilm)
      {
         login = new LoginPage(ilm);
         Children.Add(login);

         MessagingCenter.Subscribe<ContentPage>(this, "LOGIN", (sender) => {
            SelectedItem = login;
         });
      }
   }
}
