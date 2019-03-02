using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB
{
    public class Tovar
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string About { get; set; }

        public float Price { get; set; }

        public int MagazId { get; set; }

        public virtual Magazin Magazin { get; set; }
    }
}
