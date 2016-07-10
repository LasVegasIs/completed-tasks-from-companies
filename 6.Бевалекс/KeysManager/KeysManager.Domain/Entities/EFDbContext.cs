namespace KeysManager.Domain.Entities
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

        public virtual DbSet<tbDevice> tbDevices { get; set; }
        public virtual DbSet<tbGroup> tbGroups { get; set; }
        public virtual DbSet<tbHistoryChangeKeyVal> tbHistoryChangeKeyVals { get; set; }
        public virtual DbSet<tbKey> tbKeys { get; set; }
        public virtual DbSet<tbMemberOf> tbMemberOfs { get; set; }
        public virtual DbSet<tbOrganization> tbOrganizations { get; set; }
        public virtual DbSet<tbRight> tbRights { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbDevice>()
                .HasMany(e => e.tbKeys)
                .WithRequired(e => e.tbDevice)
                .HasForeignKey(e => e.ID_DEV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbGroup>()
                .HasMany(e => e.tbMemberOfs)
                .WithRequired(e => e.tbGroup)
                .HasForeignKey(e => e.ID_GROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbOrganization>()
                .HasMany(e => e.tbDevices)
                .WithRequired(e => e.tbOrganization)
                .HasForeignKey(e => e.ID_ORG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbRight>()
                .HasMany(e => e.tbGroups)
                .WithRequired(e => e.tbRight)
                .HasForeignKey(e => e.ID_RIGHT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbRight>()
                .HasMany(e => e.tbUsers)
                .WithOptional(e => e.tbRight)
                .HasForeignKey(e => e.ID_RIGHT);
        }
    }
}
