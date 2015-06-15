using Fusillade;
using se.concode.anubis.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace se.concode.anubis
{
   public interface IMinionsService
   {
      Task<List<Minion>> GetConferences(Priority priority); 
      Task<Minion> GetConference(Priority priority, string slug); 
   }
}