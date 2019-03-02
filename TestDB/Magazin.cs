using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB
{
    public class Magazin
    {
        //[Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Tovar> Tovars { get; set; }
    }
}
