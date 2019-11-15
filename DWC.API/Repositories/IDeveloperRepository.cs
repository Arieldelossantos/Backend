using System;
using System.Collections.Generic;
using DWC.API.Models;

namespace DWC.API.Repositories
{
    public interface IDeveloperRepository
    {
        bool DoesDeveloperExist(string developerId);
        IEnumerable<Developer> All { get; }
        IEnumerable<Developer> Find(string developerName);
        void Insert(Developer developer);
        void Update(string developerId);
        void Delete(string developerId);
    }
}
