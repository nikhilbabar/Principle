using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Data
{
    public class PrincipleDataContext : DbContext
    {
        public PrincipleDataContext() : base("name=PrincipleConnection")
        {
            Database.SetInitializer(new PrincipleDatabaseInitializer());
        }

        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Input> Inputs { get; set; }
    }

    internal class PrincipleDatabaseInitializer : DropCreateDatabaseIfModelChanges<PrincipleDataContext>
    {
        protected override void Seed(PrincipleDataContext context)
        {
            IList<EntityType> entityTypes = new List<EntityType>();

            entityTypes.Add(new EntityType() { Name = "General" });
            entityTypes.Add(new EntityType() { Name = "Category" });
            entityTypes.Add(new EntityType() { Name = "Brand" });
            entityTypes.Add(new EntityType() { Name = "Product" });

            foreach (EntityType type in entityTypes)
                context.EntityTypes.Add(type);

            base.Seed(context);
        }
    }
}
