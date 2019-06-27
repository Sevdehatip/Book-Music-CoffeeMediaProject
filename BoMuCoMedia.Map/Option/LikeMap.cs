using BoMuCoMedia.Core.Map;
using BoMuCoMedia.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Map.Option
{
    public class LikeMap:CoreMap<Like>
    {
        public LikeMap()
        {
            ToTable("dbo.Likes");
           

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Likes)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.BookPost)
                .WithMany(x => x.Likes)
                .HasForeignKey(x => x.BookPostID)
                .WillCascadeOnDelete(false);
            HasRequired(x => x.MusicPost)
                .WithMany(x => x.Likes)
                .HasForeignKey(x => x.MusicPostID)
                .WillCascadeOnDelete(false);
            HasRequired(x => x.CoffeePost)
                .WithMany(x => x.Likes)
                .HasForeignKey(x => x.CoffeePostID)
                .WillCascadeOnDelete(false);
            HasRequired(x => x.BoMuCo)
                .WithMany(x => x.Likes)
                .HasForeignKey(x => x.BoMuCoID)
                .WillCascadeOnDelete(false);
        }
    }
}
