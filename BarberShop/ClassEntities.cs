using BarberShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop
{
    class ClassEntities
    {
        public static BarberShopEntities1 context { get; set; } = new BarberShopEntities1();

    }
}
