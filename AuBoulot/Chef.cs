using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuBoulot
{
    internal class Chef : Person
    {
        public void DonnerTravail(DevelopPerson dev)
        {
            dev.Travailler();
        }

        public Chef NPlusUn { get; set; }

        public List<Person> Team { get; set; } = new List<Person>();
    }
}
