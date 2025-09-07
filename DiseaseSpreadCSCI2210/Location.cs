using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DiseaseSpreadCSCI2210
{
    internal class Location
    {
        public string id { get; set; }
        public List<Person> people {  get; set; }
        public List<Location> neighbors {  get; set; }

        public Location() 
        { 
        
        }
    }
}
