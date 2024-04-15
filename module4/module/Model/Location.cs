using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module.Model
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static implicit operator Location(Breed v)
        {
            throw new NotImplementedException();
        }
    }
}
