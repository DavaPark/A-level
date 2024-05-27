using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module.Model
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int BreedId { get; set; }
        public int LocationId { get; set; }
        public Category Category { get; internal set; }
        public Location Location { get; internal set; }
        public Location Breed { get; internal set; }
    }
}
