using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblUserToken
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual TblUser User { get; set; }
    }
}
