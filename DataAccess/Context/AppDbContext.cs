using Core.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<UserRegister> UserRegisters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ArticleAndTopic>().HasKey(at => new
            //{
            //    at.ArticleId,
            //    at.TopicId
            //});

            //modelBuilder.Entity<UserAndTopic>().HasKey(at => new
            //{
            //    at.UserId,
            //    at.TopicId
            //});
        }
    }
}
