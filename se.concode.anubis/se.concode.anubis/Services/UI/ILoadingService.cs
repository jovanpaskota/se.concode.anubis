namespace se.concode.anubis.Services.UI
{
   public interface ILoadingService
   {
      void Show(string message = "Laddar");

      void Hide();
   }
}