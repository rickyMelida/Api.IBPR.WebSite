using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;
using Newtonsoft.Json;

namespace Api.IBPR.Website.Test.DataTest
{
  public static class VersesDataExample
  {
    public static List<Verse> GetAllVerses()
    {
      return new List<Verse>
      {
        new Verse { Id = 1, Text="Ustedes son mis Amigos, si hacen lo que les mando", Book="Juan", Chapter=15, Versse=14 },
        new Verse { Id = 2, Text="Vengan a mí todos los que están cansados y llevan cargas pesadas, y yo les daré descanso.", Book="Mateo", Chapter=11, Versse=28 }
      };
    }
  }
}