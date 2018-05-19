namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShoppeDbContext : DbContext
    {
        public ShoppeDbContext()
            : base("name=Shoppe1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAbout> tblAbouts { get; set; }
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblContact> tblContacts { get; set; }
        public virtual DbSet<tblContent> tblContents { get; set; }
        public virtual DbSet<tblContentTag> tblContentTags { get; set; }
        public virtual DbSet<tblFeedback> tblFeedbacks { get; set; }
        public virtual DbSet<tblFooter> tblFooters { get; set; }
        public virtual DbSet<tblMenu> tblMenus { get; set; }
        public virtual DbSet<tblMenuType> tblMenuTypes { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProductCategory> tblProductCategories { get; set; }
        public virtual DbSet<tblSlide> tblSlides { get; set; }
        public virtual DbSet<tblSystemConfig> tblSystemConfigs { get; set; }
        public virtual DbSet<tblTag> tblTags { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAbout>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblAbout>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblAbout>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblAbout>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<tblCategory>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblCategory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblCategory>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblCategory>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<tblCategory>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblContent>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblContent>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblContent>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblContent>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<tblContent>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblContentTag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<tblProductCategory>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductCategory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductCategory>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductCategory>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<tblSlide>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblSlide>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemConfig>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<tblTag>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.GroupID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }
    }
}
