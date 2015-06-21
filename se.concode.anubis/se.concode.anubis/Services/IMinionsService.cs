using Fusillade;
using se.concode.anubis.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace se.concode.anubis
{
   public interface IMinionsService
   {
      Task<List<Minion>> GetMinions(Priority priority); 
      Task<Minion> GetMinion(Priority priority, string slug); 
   }
}