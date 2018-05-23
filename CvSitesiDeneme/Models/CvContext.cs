using System;
using System.Collections.Generic;
using System.Configuration;
using CvSitesiDeneme.Migrations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CvSitesiDeneme.Models
{
    public class CvContext : DbContext
    {
        public CvContext() : base("CvContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CvContext, Migrations.Configuration>("CvContext"));
        }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.AllOf> AllOfs { get; set; }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.AboutMe> AboutMes { get; set; }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.Certificated> Certificateds { get; set; }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.Education> Educations { get; set; }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.Entery> Enteries { get; set; }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.Experiance> Experiances { get; set; }

        public System.Data.Entity.DbSet<CvSitesiDeneme.Models.Skill> Skills { get; set; }
    }
}