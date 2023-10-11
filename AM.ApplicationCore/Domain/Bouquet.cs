using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Bouquet
    {

        public string AccompagningMessage { get; set; }
        [Key]
        public int BouquetCode { get; set; }
        public BouquetType BouquetType { get; set; }
        public DateTime CreationDate { get; set; }
        
        //prop de navigation
        public virtual List<Flower> Flowers { get; set; }
        public  virtual Customer Customer { get; set; }
        
    }
}
