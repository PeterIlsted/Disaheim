using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    internal class MerchandiseRepository
    {
        Merchandise merchandise;
        public List<Merchandise> merchandises;
        public List<Merchandise> AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
            return merchandises;
        }
        public Merchandise GetMerchandise(string itemId)
        {
            foreach (var merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                {
                    return merchandise;
                    break;
                }
            }
            return merchandise;
        }
        public double GetTotalValue()
        {
            double value = 0;
            double totalValue = 0;
            foreach (Merchandise merchandise in merchandises)
            {
                value = Utility.GetValueOfMerchandise(merchandise);
                totalValue = totalValue + value;
            }
            return totalValue;
        }
    }
    
}
