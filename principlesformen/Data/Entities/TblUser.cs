using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblComment = new HashSet<TblComment>();
            TblPost = new HashSet<TblPost>();
            TblUserClaim = new HashSet<TblUserClaim>();
            TblUserLogin = new HashSet<TblUserLogin>();
            TblUserRole = new HashSet<TblUserRole>();
            TblUserToken = new HashSet<TblUserToken>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<TblComment> TblComment { get; set; }
        public virtual ICollection<TblPost> TblPost { get; set; }
        public virtual ICollection<TblUserClaim> TblUserClaim { get; set; }
        public virtual ICollection<TblUserLogin> TblUserLogin { get; set; }
        public virtual ICollection<TblUserRole> TblUserRole { get; set; }
        public virtual ICollection<TblUserToken> TblUserToken { get; set; }
    }
}
