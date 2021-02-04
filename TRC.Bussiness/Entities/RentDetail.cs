using BRC.Bussiness.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRC.Bussiness.Entities
{
    public class RentDetail : IBaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public double PriceByDay { get; set; }
        public int RentDays { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; } 
        public virtual Employee Employee { get; set; }
        //public virtual Inspection Inspection { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }
}
