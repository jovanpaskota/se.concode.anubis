using Refit;
using se.concode.anubis.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace se.concode.anubis
{
   public interface IConcodeApi
   {
      [Get("/minions")]
      Task<List<Minion>> GetMinions();

      [Get("/minions/{slug}")]
      Task<Minion> GetMinion(string slug);
   }
}