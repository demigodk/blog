using System;
using System.Collections.Generic;

namespace blog.Data.Entities
{
    public partial class TblUserPhoto
    {
        public int UserPhotoId { get; set; }
        public byte[] Photo { get; set; }
        public string UserId { get; set; }

        public virtual TblUser User { get; set; }
    }
}
