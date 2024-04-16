using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Disaheim
{
    public class Controller
    {
        ValuableRepository ValuableRepo = new ValuableRepository();
        public Controller() { }
        public ValuableRepository AddToList(IValuable valuable)
        {
            ValuableRepo.AddValuable(valuable);
            return ValuableRepo;
        }
    }
}
