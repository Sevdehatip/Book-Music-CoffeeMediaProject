using BoMuCoMedia.Core.Map;
using BoMuCoMedia.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Map.Option
{
    public class BookPostMap:CoreMap<BookPost>
    {
        public BookPostMap()
        {
            ToTable("dbo.BookPosts");
            
            Property(x => x.ImagePath).IsOptional();
            Property(x => x.VideoPath).IsOptional();
            Property(x => x.BookName).IsOptional();
            Property(x => x.AuthorName).IsOptional();
            Property(x => x.BookType).IsOptional();
            Property(x => x.Quote).IsOptional();
            Property(x => x.RecommendRate).IsOptional();
            Property(x => x.Favorite).IsOptional();
            Property(x => x.OnSale).IsOptional();
            Property(x => x.Gift).IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.BookPosts)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Comments)
               .WithRequired(x => x.BookPost)
               .HasForeignKey(x => x.BookPostID)
               .WillCascadeOnDelete(false);
            HasMany(x => x.Likes)
                .WithRequired(x => x.BookPost)
                .HasForeignKey(x => x.BookPostID)
                .WillCascadeOnDelete(false);
            
        }
    }
}
