using BoMuCoMedia.Core.Map;
using BoMuCoMedia.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Map.Option
{
    public class MusicPostMap:CoreMap<MusicPost>
    {
        public MusicPostMap()
        {
            ToTable("dbo.MusicPosts");

            Property(x => x.ImagePath).IsOptional();
            Property(x => x.VideoPath).IsOptional();
            Property(x => x.SongName).IsOptional();
            Property(x => x.SingerName).IsOptional();
            Property(x => x.MusicType).IsOptional();
            Property(x => x.RecommendRate).IsOptional();
            Property(x => x.Favorite).IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.MusicPosts)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Comments)
               .WithRequired(x => x.MusicPost)
               .HasForeignKey(x => x.MusicPostID)
               .WillCascadeOnDelete(false);
            HasMany(x => x.Likes)
                .WithRequired(x => x.MusicPost)
                .HasForeignKey(x => x.MusicPostID)
                .WillCascadeOnDelete(false);
        }
    }
}
