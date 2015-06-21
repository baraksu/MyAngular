using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class Yad2Context: DbContext
    {
        public DbSet<RentApartment> RentApartments { get; set; }

        public Yad2Context():base("DAL.Yad2Context")
        {

        }

    }
}
