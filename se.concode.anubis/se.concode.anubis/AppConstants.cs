using System;
using Xamarin.Forms;

namespace se.concode.anubis
{
   public static class AppConstants
   {
      public static string AppHome = "http://www.concode.se/";

      public static readonly Font TitleFont = Font.SystemFontOfSize(Device.OnPlatform(iOS: 18, Android: 20, WinPhone: 24), FontAttributes.None);

      public static readonly Color TitleColor = Device.OnPlatform(iOS: Color.FromHex("0099CD"), Android: Color.FromHex("0099CD"), WinPhone: Color.FromHex("0099CD"));

      public static readonly Font SubtitleFont = Font.SystemFontOfSize(Device.OnPlatform(iOS: 12, Android: 14, WinPhone: 16), FontAttributes.None);

      public static readonly Font EntryLabelFont = Font.SystemFontOfSize(Device.OnPlatform(iOS: 12, Android: 14, WinPhone: 16), FontAttributes.None);

      public static readonly Font MenuFont = Font.SystemFontOfSize(Device.OnPlatform(iOS: 14, Android: 16, WinPhone: 18), FontAttributes.None);

      public static readonly GridLength ToolbarHeight = Device.OnPlatform(iOS: 66, Android: 66, WinPhone: 66);

      public static readonly Color ToolbarBackground = Device.OnPlatform(iOS: Color.FromHex("292929"), Android: Color.FromHex("292929"), WinPhone: Color.FromHex("292929"));

      public static readonly Color LoginBackground = Device.OnPlatform(iOS: Color.FromHex("0099CD"), Android: Color.FromHex("0099CD"), WinPhone: Color.FromHex("0099CD"));

      public static readonly Font CommentTitleFont = Font.SystemFontOfSize(Device.OnPlatform(iOS: 16, Android: 18, WinPhone: 20), FontAttributes.None);

      public static readonly Font CommentDateFont = Font.SystemFontOfSize(Device.OnPlatform(iOS: 12, Android: 14, WinPhone: 16), FontAttributes.Italic);

      public static readonly Font CommentBodyFont = Font.SystemFontOfSize(Device.OnPlatform(iOS: 14, Android: 16, WinPhone: 18), FontAttributes.None);

      public static readonly Color CommentTitleColor = Device.OnPlatform(iOS: Color.FromHex("0099CD"), Android: Color.FromHex("0099CD"), WinPhone: Color.FromHex("0099CD"));

      public static readonly Color CommentDateColor = Device.OnPlatform(iOS: Color.FromHex("333333"), Android: Color.FromHex("333333"), WinPhone: Color.FromHex("333333"));

      public static string ToByteString(this int totalSize)
      {
         var size = Math.Round(totalSize * 1D);
         if (size > 0 && size < 1024)
         {
            return size.ToString("### ###.# B");
         }
         if (size > 1023 && size < 1048575)
         {
            return (size / 1024).ToString("### ### ###.# KB");
         }
         if (size > 1048574 && size < 1073741824)
         {
            return (size / 1024 / 1024).ToString("### ### ###.# MB");
         }
         return size > 1073741823 ? (size / 1024 / 1024 / 1024).ToString("### ### ###.# GB") : " ";
      }

   }
}
