
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : Service<Bouquet>, IServiceBouquet
    {
        public List<Bouquet> Bouquets => GetAll().ToList();


        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {


        }
        public List<Bouquet> GetBouquetsByCustomer(Customer customer)
        {
            //with LINQ language
            IEnumerable<Bouquet> req = (IEnumerable<Bouquet>)(from b in Bouquets
                                                              where b.Customer.Equals(customer)
                                                              group b by b.BouquetType);

            return req.OrderBy(t=>t.CreationDate).ToList();


        }

        public double GetPriceBouquet(Bouquet bouquet)
        {

            //with LINQ language
            IEnumerable<Bouquet> req = from bb in Bouquets
                                       where bb.Equals(bouquet)
                                       select bb;

            Bouquet b = req.FirstOrDefault();
            double price = 0;

            if (b.BouquetType.Equals(BouquetType.Round))
            {
                foreach (Flower f in b.Flowers)
                {
                    price += f.Price;
                }
                price = price + price * 0.3;
            }

            if (b.BouquetType.Equals(BouquetType.Conical))
            {
                foreach (Flower f in b.Flowers)
                {
                    price += f.Price;
                }
                price = price + price * 0.15;
            }

            return price;
        }

    }
}
