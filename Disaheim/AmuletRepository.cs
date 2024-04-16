using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {
        Amulet amulet;

        private List<Amulet> amulets = new List<Amulet>();
        public List<Amulet> AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
            return amulets;
        }
        public Amulet GetAmulet(string itemId)
        {
            foreach (var amulet in amulets)
            {
                if (amulet.ItemId == itemId)
                {
                    return amulet;
                    break;
                }
            }
            return amulet;
        }
        public double GetTotalValue()
        {
            double value = 0;
            double totalValue = 0;
            foreach (Amulet amulet in amulets)
            {
                value = Utility.GetValueOfMerchandise(amulet);
                totalValue = totalValue + value;
            }
            return totalValue;
        }
    }
}
