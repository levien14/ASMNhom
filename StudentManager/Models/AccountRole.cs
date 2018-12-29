using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class AccountRole
    {
        public float Id { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
