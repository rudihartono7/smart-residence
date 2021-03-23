using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrisaTech.SmartResidence.Persistence.Entities;

namespace TrisaTech.SmartResidence.Persistence
{
    public class SmartResidenceContext: DbContext
    {
        public SmartResidenceContext(DbContextOptions<SmartResidenceContext> options)
            :base(options)
        {

        }
        public virtual DbSet<Residence> Residences { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }
        public virtual DbSet<ResidentFamily> ResidentFamilies { get; set; }
        public virtual DbSet<GuestBook> GuestBooks { get; set; }
        public virtual DbSet<ResidentFund> ResidentFunds { get; set; }
        public virtual DbSet<ResidentBill> ResidentBills { get; set; }
        public virtual DbSet<ResidentProgram> ResidentPrograms { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
