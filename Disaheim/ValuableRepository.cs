using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        List<IValuable> valuables = new List<IValuable>();
        public IValuable AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
            return valuable;
        }
        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merchandise)
                {
                    if (merchandise.ItemId == id) 
                        return valuable; 
                }
                else if (valuable is Course course)
                {
                    if (course.Name == id)
                        return valuable; 
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double value = 0;
            double totalValue = 0;
            foreach (var valuable in valuables)
            {
                value = valuable.GetValue();
                totalValue = totalValue + value;
            }
            return totalValue;
        }
        public int Count()
        {
            int count = 0;
            count = valuables.Count;
            return count;
        }
    }
}
