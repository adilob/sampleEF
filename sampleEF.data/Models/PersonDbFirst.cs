using System;
using System.Collections.Generic;

#nullable disable

namespace sampleEF.data.Models
{
    public partial class PersonDbFirst
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
