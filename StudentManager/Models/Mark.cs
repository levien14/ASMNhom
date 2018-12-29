using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public float Value { get; set; }
        public MarkType MarkType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
    public enum MarkType {
        Theory = 1,
        Practice = 2,
        Assingment = 3
    }
}
