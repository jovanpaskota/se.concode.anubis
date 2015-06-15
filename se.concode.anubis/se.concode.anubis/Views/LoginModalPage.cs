using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace se.concode.anubis.Views
{
   public class LoginModalPage : CarouselPage
   {
      ContentPage login, create;

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
