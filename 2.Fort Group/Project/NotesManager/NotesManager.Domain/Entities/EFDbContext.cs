namespace NotesManager.Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=EFDbContext")
        {
        }

        public virtual DbSet<tbNote> tbNotes { get; set; }
        public virtual DbSet<tbPremission> tbPremissions { get; set; }
        public virtual DbSet<tbRolePremission> tbRolePremissions { get; set; }
        public virtual DbSet<tbRole> tbRoles { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbPremission>()
                .HasMany(e => e.tbRolePremissions)
                .WithRequired(e => e.tbPremission)
                .HasForeignKey(e => e.ID_PREMISSION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbRole>()
                .HasMany(e => e.tbRolePremissions)
                .WithRequired(e => e.tbRole)
                .HasForeignKey(e => e.ID_ROLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbRole>()
                .HasMany(e => e.tbUsers)
                .WithRequired(e => e.tbRole)
                .HasForeignKey(e => e.ID_ROLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbNotes)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.ID_USER)
                .WillCascadeOnDelete(false);
        }
    }
}
