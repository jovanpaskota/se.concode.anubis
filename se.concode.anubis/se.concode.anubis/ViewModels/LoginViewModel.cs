using System.Diagnostics;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using se.concode.anubis.Services.UI;
using Xamarin.Forms;
using se.concode.anubis.Helpers;

namespace se.concode.anubis.ViewModels
{
   public class LoginViewModel : ViewModelBase
   {

      public const string UsernamePropertyName = "Username";
      string _username = "";

      /// <summary>
      /// Gets or sets the username.
      /// </summary>
      /// <value>The username.</value>
      public string Username
      {
         get { return _username; }
         set
         {
            if (Equals(_username, value))
               return;
            var oldValue = _username;
            _username = value;
            RaisePropertyChanged(() => Username, oldValue, value, true);
         }
      }

      public const string PasswordPropertyName = "Password";
      string _password = "";

      /// <summary>
      /// Gets or sets the password.
      /// </summary>
      /// <value>The password.</value>
      public string Password
      {
         get { return _password; }
         set
         {
            if (Equals(_password, value))
               return;
            var oldValue = _password;
            _password = value;
            RaisePropertyChanged(() => Password, oldValue, value, true);
         }
      }

      Command _loginCommand;
      public const string LoginCommandPropertyName = "LoginCommand";

      public Command LoginCommand
      {
         get
         {
            return _loginCommand ?? (_loginCommand = new Command(async () => await ExecuteLoginCommand()));
         }
      }

      readonly ILoadingService _loadingService;

      public LoginViewModel()
      {
         _loadingService = DependencyService.Get<ILoadingService>();
      }

      protected async Task ExecuteLoginCommand()
      {
         if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
         {
            MessagingCenter.Send<ViewModelBase>(this, "VALIDATIONERROR");
            return;
         }
//         _loadingService.Show();
//
//         var apiService = new DoxApiService();
//         var requestModel = new DoxUserRequestModel
//         {
//            UserName = Username,
//            Password = Password.ToSha1(),
//            UsePortalLogin = true
//         };
//
//         var responseModel = await apiService.GetPortalTicket(requestModel);
//
//         if (null == responseModel)
//         {
//            MessagingCenter.Send<ViewModelBase>(this, "VALIDATIONERROR");
//            _loadingService.Hide();
//            return;
//         }
//
//         Settings.Ticket = responseModel.Ticket;
//         Settings.LoginName = Username;
         MessagingCenter.Send<LoginViewModel>(this, "PORTALLOGINACCEPTED");
      }

      protected void ExecuteRegisterCommand()
      {
         MessagingCenter.Send<ViewModelBase>(this, "OPENREGISTERPAGE");
      }
   }
}