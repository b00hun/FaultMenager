using FaultMenager_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultMenagerBLL.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Project configuration

            modelBuilder.Entity<Project>()
                .HasKey(p => p.ProjectId);


            modelBuilder.Entity<Project>()
                .Property(p => p.ProjectName)
                .IsRequired()
                .HasMaxLength(25);


            modelBuilder.Entity<Project>()
                .Property(p => p.ProjectAdress)
                .IsRequired()
                .HasMaxLength(50);

           
        }

    }

    
}
