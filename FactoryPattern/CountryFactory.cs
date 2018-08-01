using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CountryFactory
    {
        IAsia _asia;
        public CountryFactory(IAsia asia)
        {
            _asia = asia;
        }

        public string HelloFromCountry()
        {
           return _asia.Hello();
        }
    }
}
