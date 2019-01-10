namespace LGroup.Curso.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration 
        : DbMigrationsConfiguration<Contexts.ContextExterno>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Contexts.ContextExterno context)
        {
        }
    }
}
