using System;
using System.Collections.Generic;
using DWC.API.Models;
using DWC.API.Services;

namespace DWC.API.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
    {
        protected readonly DataService _dataService;

        public DeveloperRepository(DataService dataService)
        {
            _dataService = dataService;
        }

        public IEnumerable<Developer> All => _dataService.GetDbContext().Developers;

        public void Delete(string developerId)
        {
            //throw new NotImplementedException();
        }

        public bool DoesDeveloperExist(string developerId)
        {
            return false;
        }

        public IEnumerable<Developer> Find(string developerName)
        {
            return null;
        }

        public void Insert(Developer developer)
        {
           
        }

        public void Update(string developerId)
        {
           
        }
    }
}
