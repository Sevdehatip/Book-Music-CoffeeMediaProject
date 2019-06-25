using BoMuCoMedia.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Model.Option
{
    public class MusicPost:CoreEntity
    {
        public string ImagePath { get; set; }
        public string VideoPath { get; set; }
        public string SongName { get; set; }
        public string SingerName { get; set; }
        public string MusicType { get; set; }
        public string RecommendRate { get; set; }
        public string Favorite { get; set; }
        

        public Guid AppUserID { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }
    }
}
