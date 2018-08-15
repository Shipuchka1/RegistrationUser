namespace RegistrationUser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phone")]
    public partial class Phone
    {
        public int PhoneId { get; set; }

        public int? UserId { get; set; }

        public int? PhoneTypeId { get; set; }

        [StringLength(50)]
        public string СountryСode { get; set; }

        [StringLength(150)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string AddNumber { get; set; }

        [StringLength(50)]
        public string PhoneCode { get; set; }

        public virtual dic_PhoneType dic_PhoneType { get; set; }
    }
}
