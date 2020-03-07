using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblUserClaim
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual TblUser User { get; set; }
    }
}
