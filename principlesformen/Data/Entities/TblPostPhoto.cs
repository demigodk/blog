using System;
using System.Collections.Generic;

namespace blog.Data.Entities
{
    public partial class TblPostPhoto
    {
        public int Id { get; set; }
        public byte[] ImageData { get; set; }
        public int PostId { get; set; }

        public virtual TblPost Post { get; set; }
    }
}
