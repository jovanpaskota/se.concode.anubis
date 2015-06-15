namespace se.concode.anubis
{
   public interface IApiService
   {
      IConcodeApi Speculative { get; }
      IConcodeApi UserInitiated { get; }
      IConcodeApi Background { get; }
   }
}