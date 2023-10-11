using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flower
    {

        public string Color { get; set; }
        public int FlowerId { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 2000)]
        public float Price { get; set; }
        
        
        //prop de navigation
      
        public  virtual Bouquet Bouquet { get; set; }
        public int BouquetFK { get; set; }
        

    }
}
