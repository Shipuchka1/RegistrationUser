namespace RegistrationUser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dic_Country
    {
        [Key]
        public int CountryId { get; set; }

        [StringLength(36)]
        public string GUID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Name_En { get; set; }

        [StringLength(250)]
        public string Name_Kk { get; set; }

        [StringLength(250)]
        public string Name_Uz { get; set; }

        [StringLength(250)]
        public string Name_Kg { get; set; }

        public DateTime? ChangeDate { get; set; }

        [StringLength(50)]
        public string CodePhone { get; set; }

        public int? Status { get; set; }
    }
}
