using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDroup.Models.ViewModel
{
    public class CreateAll
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public int country { get; set; }
        public int state { get; set; }
        public int city { get; set; }
    }
}
