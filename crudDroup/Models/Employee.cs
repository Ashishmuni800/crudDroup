using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDroup.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public country country { get; set; }
        public state state { get; set; }
        public City city { get; set; }

    }
}
