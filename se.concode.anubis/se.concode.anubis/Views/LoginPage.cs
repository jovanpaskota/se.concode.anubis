using GalaSoft.MvvmLight;
using se.concode.anubis.Services;
using se.concode.anubis.ViewModels;
using Xamarin.Forms;

namespace se.concode.anubis.Views
{
   public class LoginPage : ContentPage
   {
      public LoginPage(ILoginManager ilm)
      {
         var viewModel = new LoginViewModel();
         BindingContext = viewModel;

         BackgroundColor = AppConstants.ToolbarBackground;

         MessagingCenter.Subscribe<ViewModelBase>(this, "VALIDATIONERROR", (sender) => DisplayAlert("Validation Error", "Username and Password are required", "Re-try"));

         MessagingCenter.Subscribe<LoginViewModel>(this, "PORTALLOGINACCEPTED", (sender) => ilm.ShowMainPage());

         var logo = new Image { Source = "lovgrens_logo", WidthRequest = 200, HeightRequest = 75, Aspect = Aspect.AspectFit };

         var button = new Button
         {
            Text = "Sign In",
            TextColor = Color.White,
            BackgroundColor = Color.FromHex("ff7e57")
         };

         button.SetBinding(Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);

         var username = new Entry { Placeholder = L10n.Localize("Username", "Username"), TextColor = Color.White, Keyboard = Keyboard.Email };
         username.SetBinding(Entry.TextProperty, LoginViewModel.UsernamePropertyName);

         var password = new Entry { Placeholder = L10n.Localize("Password", "Password"), TextColor = Color.White, IsPassword = true };
         password.SetBinding(Entry.TextProperty, LoginViewModel.PasswordPropertyName);

         Content = new StackLayout
         {
            Spacing = 20,
            Padding = 50,
            VerticalOptions = LayoutOptions.Center,
            Children = {
               logo,
               username,
               password,
               button
            }
         };
      }
   }
}