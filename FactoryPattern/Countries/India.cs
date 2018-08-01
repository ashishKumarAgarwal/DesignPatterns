using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class India : IAsia
    {
        public string Hello()
        {
            return "Namaste !";
        }
    }
}
