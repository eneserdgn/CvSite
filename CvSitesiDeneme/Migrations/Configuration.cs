namespace CvSitesiDeneme.Migrations
{
    using CvSitesiDeneme.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CvSitesiDeneme.Models.CvContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CvSitesiDeneme.Models.CvContext";
        }

        protected override void Seed(CvSitesiDeneme.Models.CvContext context)
        {
           
           
        }
    }
}
