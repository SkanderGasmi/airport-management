using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class ArtificialFlower : Flower
    {

        public DateTime ManufactureDate { get; set; }
        public string Material { get; set; }
               
        //prop de navigation
        
    }
}
