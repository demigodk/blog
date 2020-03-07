using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblTag
    {
        public TblTag()
        {
            TblPost = new HashSet<TblPost>();
        }

        public int TagId { get; set; }
        public string Tag { get; set; }

        public virtual ICollection<TblPost> TblPost { get; set; }
    }
}
