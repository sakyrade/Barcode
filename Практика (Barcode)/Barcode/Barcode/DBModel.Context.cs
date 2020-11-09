namespace Barcode
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BarcodesEntities : DbContext
    {
        public BarcodesEntities()
            : base("name=BarcodesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CountryBarcodes> CountryBarcodes { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
    }
}
