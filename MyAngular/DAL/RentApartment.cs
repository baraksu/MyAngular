using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class RentApartment {

        [Key]
        public int Id { get; set; }

        public string Kind { get; set; }

        public string Area { get; set; }

        public string Address { get; set; }

        public string Price { get; set; }

        public int Rooms { get; set; }

        public string Entrence { get; set; }

        public int Floor { get; set; }

        public DateTime Date {get;set;}




    }
}
