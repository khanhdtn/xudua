namespace XuDua.Da.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class XuDuaContext : DbContext
    {
        public XuDuaContext()
            : base("name=XuDuaContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserGroupType> UserGroupTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.UserGroups)
                .WithMany(e => e.Users)
                .Map(m => m.ToTable("UG_U").MapLeftKey("UserID").MapRightKey("UserGroupID"));
        }
    }
}
