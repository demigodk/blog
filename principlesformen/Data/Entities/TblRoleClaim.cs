﻿using System;
using System.Collections.Generic;

namespace blog.Data.Entities
{
    public partial class TblRoleClaim
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual TblRole Role { get; set; }
    }
}
