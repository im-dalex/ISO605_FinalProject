using BRC.Bussiness.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRC.Bussiness.Entities
{
    public class Inspection : IBaseEntity
    {
        //add tires inspection
        public int Id { get; set; }
        //public int EmployeeId { get; set; }
        //public int VehicleId { get; set; }
        //public int CustomerId { get; set; }
        public int RentDetailId { get; set; }
        public bool IsGrated { get; set; }
        public double FuelQuantity { get; set; }
        public bool HasHydraulicCat { get; set; }
        public bool HasSpareTire { get; set; }
        public bool HasBrokenMirror { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public virtual RentDetail RentDetail { get; set; }
        //public virtual Customer Customer { get; set; }
        //public virtual Vehicle Vehicle { get; set; }
        //public virtual Employee Employee { get; set; }
    }
}
