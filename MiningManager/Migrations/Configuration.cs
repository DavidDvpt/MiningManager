namespace MiningManager.Migrations
{
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MiningManager.Repository.MiningContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MiningManager.Repository.MiningContext context)
        {
            if (context.Communs.Count() == 0)
            {
                string script = File.ReadAllText(@"H:\Data\script.sql");
                context.Database.ExecuteSqlCommand(script);
            }

        }
    }
}
