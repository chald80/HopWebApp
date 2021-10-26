using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HopClassLib;

namespace HopWebApp.Managers
{
    public class HopManager
        {
            private static int _nextId = 1;

            private static readonly List<Hop> Data = new List<Hop>
            {
                new Hop {Id = _nextId++, Name = "1", HarvestYear = 1, Price = 1, AlphaAcid = 1},
                new Hop {Id = _nextId++, Name = "2", HarvestYear = 2, Price = 2, AlphaAcid = 2},
                new Hop {Id = _nextId++, Name = "3", HarvestYear = 3, Price = 3, AlphaAcid = 3}
            };

            public List<Hop> GetAll()
            {
                return new List<Hop>(Data);
            }

            public Hop GetById(int id)
            {
                return Data.Find(h => h.Id == id);
            }

            public Hop Add(Hop newHop)
            {
                newHop.Id = _nextId;
                Data.Add(newHop);
                return newHop;
            }

            public Hop Delete(int id)
            {
                Hop hop = Data.Find(h => h.Id == id);
                if (hop == null) return null;
                Data.Remove(hop);
                return hop;
                {
                    
                }
            }

        }
    
}
