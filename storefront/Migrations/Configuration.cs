namespace storefront.Migrations
{
    using storefront.Models;
    using System.Data.Entity.Migrations;
    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Context context)
        {
            context.Categories.AddOrUpdate(r => r.Id,
                new Category() { Id = 1, Name = "Fashion" },
                new Category() { Id = 2, Name = "Beauty" },
                new Category() { Id = 3, Name = "Gaming" },
                new Category() { Id = 4, Name = "Technology" },
                new Category() { Id = 5, Name = "Grocery" });
           


        }
    }
}
