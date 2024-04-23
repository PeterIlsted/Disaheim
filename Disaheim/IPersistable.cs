using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public interface IPersistable
    {

        public void Save();
        public void Save(string fileName);
        public List<IValuable> Load();
        public List<IValuable> Load(string fileName);
    }
}
