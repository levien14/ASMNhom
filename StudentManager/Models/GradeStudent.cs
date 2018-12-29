using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class GradeStudent
    {
        public long Id { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public DateTime JoinAt { get; set; }
    }
}
