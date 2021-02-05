using BRC.Bussiness.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BRC.Bussiness.Entities
{
    public class ReturnDetail : IBaseEntity
    {
        [Key]
        [Column("ReturnDetailId")]
        public int Id { get; set; }
        [Required]
        [ForeignKey("RentDetail")] 
        public int RentDetailId { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(200)]
        public string Comment { get; set; }
        [Required]
        [DefaultValue("A")]
        public string Status { get; set; }

        public virtual RentDetail RentDetail { get; set; }
    }
}
