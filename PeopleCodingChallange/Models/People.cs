using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeopleCodingChallange.Models
{
    public class People
    {

        public int PeopleID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Interests { get; set; }
        public string Picture { get; set; }
    }

    public class PeopleConext: DbContext
    {
       public DbSet<People> people { get; set; }
    }

}