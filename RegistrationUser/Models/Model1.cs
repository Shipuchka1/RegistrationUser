namespace RegistrationUser.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<MyAddress> Addresses { get; set; }
        public virtual DbSet<dic_AddressType> dic_AddressType { get; set; }
        public virtual DbSet<dic_Bank> dic_Bank { get; set; }
        public virtual DbSet<dic_City> dic_City { get; set; }
        public virtual DbSet<dic_Country> dic_Country { get; set; }
        public virtual DbSet<dic_Currency> dic_Currency { get; set; }
        public virtual DbSet<dic_PhoneType> dic_PhoneType { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dic_AddressType>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
