namespace Kutuphane.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Kutuphane.DataAccess.Baglanti.KutuphaneContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;//migrations sırasında veri kayıplarını kabul ettiğimizi belirttik
        }

        protected override void Seed(Kutuphane.DataAccess.Baglanti.KutuphaneContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
