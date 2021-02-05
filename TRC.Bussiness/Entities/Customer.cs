using BRC.Bussiness.Entities.Base;
using System.Collections.Generic;

namespace BRC.Bussiness.Entities
{
    public class Customer : IBasePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string CreditCard { get; set; }
        public int CreditLimit { get; set; }
        public string PersonType { get; set; }
        public string Status { get; set; }

        public virtual ICollection<RentDetail> RentDetail { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }
}
