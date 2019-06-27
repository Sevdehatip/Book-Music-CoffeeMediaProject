using BoMuCoMedia.Core.Map;
using BoMuCoMedia.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Map.Option
{
    public class CoffeePostMap: CoreMap<CoffeePost>
    {
        public CoffeePostMap()
        {
            ToTable("dbo.CoffeePosts");

            Property(x => x.ImagePath).IsOptional();
            Property(x => x.VideoPath).IsOptional();
            Property(x => x.CoffeeName).IsOptional();
            Property(x => x.BrewingType).IsOptional();
            Property(x => x.DrinkType).IsOptional();
            Property(x => x.CoffeeMaker).IsOptional();
            Property(x => x.RecommendRate).IsOptional();
            Property(x => x.Favorite).IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.CoffeePosts)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Comments)
               .WithRequired(x => x.CoffeePost)
               .HasForeignKey(x => x.CoffeePostID)
               .WillCascadeOnDelete(false);
            HasMany(x => x.Likes)
                .WithRequired(x => x.CoffeePost)
                .HasForeignKey(x => x.CoffeePostID)
                .WillCascadeOnDelete(false);
        }
    }
}
