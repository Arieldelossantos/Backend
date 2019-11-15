using System;
using DWC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DWC.API.Services
{
    public class DataService
    {
        private readonly DWCContext _DWCData;

        public DataService(IServiceProvider serviceProvider)
        {
            _DWCData = serviceProvider.GetRequiredService<DWCContext>(); ;
        }

        public DWCContext GetDbContext() => _DWCData;
    }
}
