using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogFluent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogFluent.Data.Mappings
{
  public class PostMap : IEntityTypeConfiguration<Post>
  {
    public void Configure(EntityTypeBuilder<Post> builder)
    {
      builder.ToTable("Post");

      builder.HasKey(x => x.Id);
      builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

      builder.Property(x => x.LastUpdateDate).IsRequired().HasColumnName("LastUpdateDate").HasColumnType("SMALLDATETIME")
      .HasDefaultValueSql("GETDATE()");
      //.HasDefaultValue(DateTime.Now.ToUniversalTime());

      builder.HasIndex(x => x.Slug, "IX_Post_Slug").IsUnique();

      builder.HasOne(x => x.Author).WithMany(x => x.Posts).HasConstraintName("FK_Post_Author");
      builder.HasOne(x => x.Category).WithMany(x => x.Posts).HasConstraintName("FK_Post_Category");

      builder.HasMany(x => x.Tags)
       .WithMany(x => x.Posts)
       .UsingEntity<Dictionary<String, object>>(
           "PostTag",
           post => post.HasOne<Tag>()
                       .WithMany()
                       .HasForeignKey("TagId")
                       .HasConstraintName("FK_PostTag_TagId")
                       .OnDelete(DeleteBehavior.Cascade),
           tag => tag.HasOne<Post>()
                       .WithMany()
                       .HasForeignKey("PostId")
                       .HasConstraintName("FK_PostTag_PostId")
       );
    }
  }
}