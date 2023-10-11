using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
   public interface IServiceBouquet: IService<Bouquet>
    {

        public List<Bouquet> GetBouquetsByCustomer(Customer customer);
        public double GetPriceBouquet(Bouquet bouquet);
    }
}
