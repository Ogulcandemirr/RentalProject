﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JCGSI9G\\SQLEXPRESS; Database=CarRentalProjectDb; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2 { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide>  Guides { get; set; }
        public DbSet<NewsLetter> NewsLettes { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testİmonial> Testİmonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<RentCondition> RentConditions { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}

