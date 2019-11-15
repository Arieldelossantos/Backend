using System;
using System.Collections.Generic;
using DWC.API.Models;

namespace DWC.API.Services
{
    public interface IDeveloperService
    {
        IEnumerable<Developer> GetDevelopers();
        IEnumerable<Developer> FindDevelopersBy(string name);
    }
}
