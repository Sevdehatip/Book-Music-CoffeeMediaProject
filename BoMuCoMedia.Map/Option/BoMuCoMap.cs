using BoMuCoMedia.Core.Map;
using BoMuCoMedia.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Map.Option
{
    public class BoMuCoMap:CoreMap<BoMuCo>
    {
        public BoMuCoMap()
        {
            ToTable("dbo.BoMuCo");

            Property(x => x.ImagePath).IsOptional();
            Property(x => x.VideoPath).IsOptional();
            Property(x => x.CoffeeName).IsOptional();
            Property(x => x.BookName).IsOptional();
            Property(x => x.SongName).IsOptional();
            Property(x => x.Favorite).IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.BoMuCos)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Comments)
               .WithRequired(x => x.BoMuCo)
               .HasForeignKey(x => x.BoMuCoID)
               .WillCascadeOnDelete(false);
            HasMany(x => x.Likes)
                .WithRequired(x => x.BoMuCo)
                .HasForeignKey(x => x.BoMuCoID)
                .WillCascadeOnDelete(false);
        }
    }
}
