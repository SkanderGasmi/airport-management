using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class NaturalFlower : Flower
    {
        public string Origine { get; set; }
        public bool Savage { get; set; }
        [Range(1, 4)]
        public int Season { get; set; }


        //prop de navigation
        //public virtual List<Passenger> Passengers { get; set; }
    }       
}
