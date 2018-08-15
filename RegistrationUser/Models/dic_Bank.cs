namespace RegistrationUser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dic_Bank
    {
        [Key]
        public int BankId { get; set; }

        [StringLength(2500)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Bik { get; set; }

        public DateTime? ChangeDate { get; set; }

        [StringLength(50)]
        public string GuidBank { get; set; }

        public int? Status { get; set; }
    }
}
