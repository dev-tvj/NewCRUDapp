using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAPI.Models
{
    public class Address
    {
        public int Cep { get; set; }
        
        public string Country { get; set; }
        
        public string District { get; set; }
        
        public string Street { get; set; }
        
        public int Number { get; set; }
                
    }
}