using BRC.Bussiness.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRC.Bussiness.Entities
{
    public class Employee : IBasePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string Schedule { get; set; }
        public int Commission { get; set; }
        public DateTime EntryDate { get; set; }
        public string Status { get; set; }

        public virtual ICollection<RentDetail> RentDetail { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }
}
