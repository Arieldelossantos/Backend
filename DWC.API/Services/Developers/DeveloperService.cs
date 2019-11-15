using System;
using System.Collections.Generic;
using DWC.API.Models;
using DWC.API.Repositories;

namespace DWC.API.Services
{
    public class DeveloperService : IDeveloperService
    {
        IDeveloperRepository _developerRepository;

        public DeveloperService(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }

        public IEnumerable<Developer> FindDevelopersBy(string name)
        {
            return _developerRepository.Find(name);
        }

        public IEnumerable<Developer> GetDevelopers()
        {
            return _developerRepository.All;
        }
    }
}
