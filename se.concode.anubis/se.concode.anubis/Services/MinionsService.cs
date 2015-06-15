using System;
using System.Reactive.Linq;
using se.concode.anubis.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fusillade;
using Akavache;
using Polly;
using System.Net;
using Connectivity.Plugin;

namespace se.concode.anubis
{
   public class MinionsService : IMinionsService
   {
      readonly IApiService _apiService;

      public MinionsService (IApiService apiService)
      {
         _apiService = apiService;
      }

      public async Task<List<Minion>> GetConferences(Priority priority)
      {
         var cache = BlobCache.LocalMachine;
         var cachedMinions = cache.GetAndFetchLatest("minions", () => GetRemoteMinionsAsync(priority),
            offset =>
            {
               TimeSpan elapsed = DateTimeOffset.Now - offset;
               return elapsed > new TimeSpan(hours: 24, minutes: 0, seconds: 0);
            });

         var minions = await cachedMinions.FirstOrDefaultAsync();
         return minions;
      }

      public async Task<Minion> GetConference(Priority priority, string slug)
      {
         var cachedMinion = BlobCache.LocalMachine.GetAndFetchLatest(slug, () => GetRemoteMinion(priority, slug), offset =>
            {
               TimeSpan elapsed = DateTimeOffset.Now - offset;
               return elapsed > new TimeSpan(hours: 0, minutes: 30, seconds: 0);
            });

         return await cachedMinion.FirstOrDefaultAsync();
      }

      async Task<List<Minion>> GetRemoteMinionsAsync(Priority priority)
      {
         List<Minion> minions = null;
         Task<List<Minion>> getMinionsTask;
         switch (priority)
         {
         case Priority.Background:
            getMinionsTask = _apiService.Background.GetMinions();
            break;
         case Priority.UserInitiated:
            getMinionsTask = _apiService.UserInitiated.GetMinions();
            break;
         case Priority.Speculative:
            getMinionsTask = _apiService.Speculative.GetMinions();
            break;
         default:
            getMinionsTask = _apiService.UserInitiated.GetMinions();
            break;
         }

         if (CrossConnectivity.Current.IsConnected)
         {
            minions = await Policy
               .Handle<WebException>()
               .WaitAndRetry
               (
                  retryCount:5, 
                  sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
               )
               .ExecuteAsync(async () => await getMinionsTask);
         }
         return minions;
      }

      async Task<Minion> GetRemoteMinion(Priority priority, string slug)
      {
         Minion minion = null;

         Task<Minion> getMinionTask;
         switch (priority)
         {
         case Priority.Background:
            getMinionTask = _apiService.Background.GetMinion(slug);
            break;
         case Priority.UserInitiated:
            getMinionTask = _apiService.UserInitiated.GetMinion(slug);
            break;
         case Priority.Speculative:
            getMinionTask = _apiService.Speculative.GetMinion(slug);
            break;
         default:
            getMinionTask = _apiService.UserInitiated.GetMinion(slug);
            break;
         }

         if (CrossConnectivity.Current.IsConnected)
         {
            minion = await Policy
               .Handle<Exception>()
               .RetryAsync(retryCount: 5)
               .ExecuteAsync(async () => await getMinionTask);
         }

         return minion;
      }
   }
}