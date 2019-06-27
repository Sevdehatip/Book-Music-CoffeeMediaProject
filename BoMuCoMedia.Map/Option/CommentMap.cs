using BoMuCoMedia.Core.Map;
using BoMuCoMedia.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Map.Option
{
    public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.Content).IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.BookPost)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.BookPostID)
                .WillCascadeOnDelete(false);
            HasRequired(x => x.MusicPost)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.MusicPostID)
                .WillCascadeOnDelete(false);
            HasRequired(x => x.CoffeePost)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.CoffeePostID)
                .WillCascadeOnDelete(false);
            HasRequired(x => x.BoMuCo)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.BoMuCoID)
                .WillCascadeOnDelete(false);
        }
    }
}
