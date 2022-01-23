using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Fees { get; set; }
        public DateTime RegistrationEnd { get; set; }
        public bool IsActive { get; set; }
    }
}
