using BoMuCoMedia.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoMuCoMedia.Model.Option
{
    public class Comment:CoreEntity
    {
        public Guid AppUserID { get; set; }
        public Guid PostID { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual BookPost BookPost { get; set; }
        public virtual CoffeePost CoffeePost { get; set; }
        public virtual MusicPost MusicPost { get; set; }
        public virtual BoMuCo BoMuCo { get; set; }
    }
}
