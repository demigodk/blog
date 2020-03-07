using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblPost = new HashSet<TblPost>();
        }

        public int CategoryId { get; set; }
        public string Category { get; set; }

        public virtual ICollection<TblPost> TblPost { get; set; }
    }
}
