using System;
using System.Collections.Generic;

namespace blog.Data.Entities
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblRoleClaim = new HashSet<TblRoleClaim>();
            TblUserRole = new HashSet<TblUserRole>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<TblRoleClaim> TblRoleClaim { get; set; }
        public virtual ICollection<TblUserRole> TblUserRole { get; set; }
    }
}
