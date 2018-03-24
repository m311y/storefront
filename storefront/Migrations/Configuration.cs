namespace storefront.Migrations
{
    using storefront.Models;
    using System.Data.Entity.Migrations;
    internal sealed class Configuration : DbMigrationsConfiguration<storefront.DAL.StoreFrontContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(storefront.DAL.StoreFrontContext context)
        {
      

            context.Products.AddOrUpdate(x => x.Id,
        new Product() { Id = 1, Name = "Shirt" },
        new Product() { Id = 2, Name = "Pants" },
        new Product() { Id = 3, Name = "Hat" },
        new Product() { Id = 4, Name = "shoes" },
        new Product() { Id = 5, Name = "Curtains" },
        new Product() { Id = 6, Name = "Towels" },
        new Product() { Id = 7, Name = "Flowers" },
        new Product() { Id = 8, Name = "Lamp" }
        );
        }

       
    }
}
