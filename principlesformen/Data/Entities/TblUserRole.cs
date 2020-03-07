using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblUserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual TblRole Role { get; set; }
        public virtual TblUser User { get; set; }
    }
}
