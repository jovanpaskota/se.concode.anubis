using Refractored.Xam.Settings;
using Refractored.Xam.Settings.Abstractions;

namespace se.concode.anubis.Helpers
{
   public static class Settings
   {
      static ISettings AppSettings
      {
         get
         {
            return CrossSettings.Current;
         }
      }

      #region Setting Constants

      const string ApiUrlKey = "KEY-APIURL";
      static readonly string ApiUrlDefault = "http://apidev.doxcentral.com/";

      const string TicketKey = "KEY-TICKET";
      static readonly string TicketDefault = string.Empty;

      const string FilestoreKey = "KEY-FILESTOREURL";
      static readonly string FilestoreDefault = string.Empty;

      const string ProjectKey = "KEY-PROJECT";
      static readonly string ProjectDefault = string.Empty;

      const string ProjectNameKey = "KEY-PROJECTNAME";
      static readonly string ProjectNameDefault = string.Empty;

      const string LoginNameKey = "KEY-LOGINNAME";
      static readonly string LoginNameDefault = string.Empty;

      const string UserNameKey = "KEY-USERNAME";
      static readonly string UserNameDefault = string.Empty;

      const string UserIdKey = "KEY-USERID";
      static readonly string UserIdDefault = string.Empty;

      const string SessionIdKey = "KEY-SESSIONID";
      static readonly string SessionIdDefault = string.Empty;

      const string RootFolderIdKey = "KEY-ROOTFOLDERID";
      static readonly string RootFolderIdDefault = string.Empty;

      const string ServiceActionFolderIdKey = "KEY-SERVICEACTIONFOLDERID";
      static readonly string ServiceActionFolderIdDefault = string.Empty;

      const string WorkShopManualFolderIdKey = "KEY-WORKSHOPMANUALFOLDERID";
      static readonly string WorkShopManualFolderIdDefault = string.Empty;

      const string StartImageIdKey = "KEY-STARTIMAGEID";
      static readonly string StartImageIdDefault = string.Empty;

      const string PageSizeKey = "KEY-PAGESIZE";
      static readonly int PageSizeDefault = 25;

      const string PageIndexKey = "KEY-PAGEINDEX";
      static readonly int PageIndexDefault = 1;

      const string PreviewFilepathKey = "KEY-PREVIEWFILEPATH";
      static readonly string PreviewFilepathDefault = string.Empty;

      #endregion

      public static string ApiUrl
      {
         get
         {
            return AppSettings.GetValueOrDefault(ApiUrlKey, ApiUrlDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(ApiUrlKey, value);
         }
      }

      public static string Ticket
      {
         get
         {
            return AppSettings.GetValueOrDefault(TicketKey, TicketDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(TicketKey, value);
         }
      }

      public static string Filestore
      {
         get
         {
            return AppSettings.GetValueOrDefault(FilestoreKey, FilestoreDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(FilestoreKey, value);
         }
      }

      public static string Project
      {
         get
         {
            return AppSettings.GetValueOrDefault(ProjectKey, ProjectDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(ProjectKey, value);
         }
      }

      public static string ProjectName
      {
         get
         {
            return AppSettings.GetValueOrDefault(ProjectNameKey, ProjectNameDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(ProjectNameKey, value);
         }
      }

      public static string LoginName
      {
         get
         {
            return AppSettings.GetValueOrDefault(LoginNameKey, LoginNameDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(LoginNameKey, value);
         }
      }

      public static string UserName
      {
         get
         {
            return AppSettings.GetValueOrDefault(UserNameKey, UserNameDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(UserNameKey, value);
         }
      }

      public static string UserId
      {
         get
         {
            return AppSettings.GetValueOrDefault(UserIdKey, UserIdDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(UserIdKey, value);
         }
      }

      public static string SessionId
      {
         get
         {
            return AppSettings.GetValueOrDefault(SessionIdKey, SessionIdDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(SessionIdKey, value);
         }
      }

      public static string RootFolderId
      {
         get
         {
            return AppSettings.GetValueOrDefault(RootFolderIdKey, RootFolderIdDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(RootFolderIdKey, value);
         }
      }

      public static string ServiceActionFolderId
      {
         get
         {
            return AppSettings.GetValueOrDefault(ServiceActionFolderIdKey, ServiceActionFolderIdDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(ServiceActionFolderIdKey, value);
         }
      }

      public static string WorkShopManualFolderId
      {
         get
         {
            return AppSettings.GetValueOrDefault(WorkShopManualFolderIdKey, WorkShopManualFolderIdDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(WorkShopManualFolderIdKey, value);
         }
      }

      public static string StartImageId
      {
         get
         {
            return AppSettings.GetValueOrDefault(StartImageIdKey, StartImageIdDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(StartImageIdKey, value);
         }
      }

      public static int PageSize
      {
         get
         {
            return AppSettings.GetValueOrDefault(PageSizeKey, PageSizeDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(PageSizeKey, value);
         }
      }

      public static int PageIndex
      {
         get
         {
            return AppSettings.GetValueOrDefault(PageIndexKey, PageIndexDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(PageIndexKey, value);
         }
      }

      public static string PreviewFilepath
      {
         get
         {
            return AppSettings.GetValueOrDefault(PreviewFilepathKey, PreviewFilepathDefault);
         }
         set
         {
            AppSettings.AddOrUpdateValue(PreviewFilepathKey, value);
         }
      }
   }
}