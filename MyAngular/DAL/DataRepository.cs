using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataRepository : IDataRepository
    {
        public IEnumerable<RentApartment> GetAppartments()
        {
            using (var ctx = new Yad2Context())
            {
                return ctx.RentApartments.ToList();

            }

               

        }

        
    }
}
