using BRC.Bussiness.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRC.Bussiness.Entities
{
    public class Vehicle : IBaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string NoChassis { get; set; }
        public string NoMotor { get; set; }
        public string NoLicensePlate { get; set; }
        public int VehicleModelId { get; set; }
        public int FuelTypeId { get; set; }
        public string Status { get; set; }

        public FuelType FuelType { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public virtual ICollection<RentDetail> RentDetail { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }
}
