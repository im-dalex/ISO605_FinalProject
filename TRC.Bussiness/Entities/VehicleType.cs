using BRC.Bussiness.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BRC.Bussiness.Entities
{
    public class VehicleType : IBaseEntity
    {
        [Key]
        [Column("VehicleTypeId")]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [DefaultValue('A')]
        public string Status { get; set; }

        public virtual ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
