namespace se.concode.anubis.Models
{
   public class Minion
   {
      public string Id { get; set; }

      public string Name { get; set; }

      public string Category { get; set; }

      public string ExtIp { get; set; }

      public string IntIp { get; set; }

      public string Description { get; set; }

      public string Note { get; set; }

      public string Login { get; set; }
         
      public string Pass { get; set; }

      public int? Disksize { get; set; }

      public int? Disksizefree { get; set; }
   }
}