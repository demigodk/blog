using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblUserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }

        public virtual TblUser User { get; set; }
    }
}
