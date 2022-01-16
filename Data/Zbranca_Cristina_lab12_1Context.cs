using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zbranca_Cristina_lab12._1.Models;

namespace Zbranca_Cristina_lab12._1.Data
{
    public class Zbranca_Cristina_lab12_1Context : DbContext
    {
        public Zbranca_Cristina_lab12_1Context (DbContextOptions<Zbranca_Cristina_lab12_1Context> options)
            : base(options)
        {
        }

        public DbSet<Zbranca_Cristina_lab12._1.Models.ShopList> ShopList { get; set; }
    }
}
