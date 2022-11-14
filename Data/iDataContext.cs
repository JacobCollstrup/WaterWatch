using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WaterWatch.Models;

namespace WaterWatch.Data
{
    public interface iDataContext
    {
        DbSet<WaterConsumption> Consumptions {get; set;}
        int SaveChanges();
    }
}