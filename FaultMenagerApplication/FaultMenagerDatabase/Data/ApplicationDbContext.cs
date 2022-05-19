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

        public DbSet<Menager> Menagers { get; set; }



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


            //Menager configuration

            modelBuilder.Entity<Menager>()
                .HasKey(m=>m.MenagerId);

            modelBuilder.Entity<Menager>()
                .Property(m => m.MenagerName)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Menager>()
                .Property(m => m.MenagerSurname)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Menager>()
                .Property(m => m.MenagerMail)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Menager>()
                .Property(m => m.MenagerPhoneNumber)
                .IsRequired()
                .HasMaxLength(9);

            
           
        }

    }

    
}
