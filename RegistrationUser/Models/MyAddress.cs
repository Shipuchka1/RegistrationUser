namespace RegistrationUser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class MyAddress
    {
        [Key]
        public int AddressId { get; set; }

        public int? AddressTypeId { get; set; }

        public int? UserId { get; set; }

        public int? ContryId { get; set; }

        public int? CityId { get; set; }

        [StringLength(50)]
        public string PostalCode { get; set; }

        [StringLength(550)]
        public string Street { get; set; }

        [StringLength(50)]
        public string House { get; set; }

        [StringLength(50)]
        public string Housing { get; set; }

        [StringLength(50)]
        public string ApartmentOffice { get; set; }

        public virtual dic_AddressType dic_AddressType { get; set; }
    }
}
