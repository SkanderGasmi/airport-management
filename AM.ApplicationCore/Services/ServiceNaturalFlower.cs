
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceNaturalFlower : Service<NaturalFlower>, IServiceNaturalFlower
    {

        public List<NaturalFlower> naturalFlowers => GetAll().ToList();



        public ServiceNaturalFlower(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public string getNaturalFlowerLitterals()
        {
            string? s = "";

            foreach (NaturalFlower nf in naturalFlowers)
            {
                s += "Flower Name : " + nf.Name + ",Is Savage" + nf.Savage + "Season: ";
                switch (nf.Season)
                {
                    case 1:
                        s += "summer";
                        break;

                    case 2:
                        s += "Autumn";
                        break;

                    case 3:
                        s += "Winter";
                        break;

                    case 4:
                        s += "Spring";
                        break;

                    default:
                      
                        break;
                }

                s += "\n";
            }
            return s;
       
        }
    }
}
