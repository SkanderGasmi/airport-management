using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Customer
    {
        [Key]
        public string CIN { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [StringLength(8)]
        public string PhoneNumber { get; set; }
        
        //prop de navigation
        public virtual List<Bouquet> Bouquets { get; set; }
       
       
    }
}
