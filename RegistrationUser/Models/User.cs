namespace RegistrationUser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }

        [StringLength(250)]
        public string Login { get; set; }

        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string EmailElInvoice { get; set; }

        public int? IsLegalEntity { get; set; }

        [StringLength(250)]
        public string Bin { get; set; }

        [StringLength(250)]
        public string Kbe { get; set; }

        [StringLength(250)]
        public string CertSeries { get; set; }

        [StringLength(250)]
        public string CertNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CertDateIssue { get; set; }

        public int? Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(2000)]
        public string NameOrganization { get; set; }

        [StringLength(50)]
        public string User1CGuid { get; set; }

        [StringLength(250)]
        public string Surname { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Patronymic { get; set; }
    }
}
