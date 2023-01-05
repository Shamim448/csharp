using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Fee { get; set; }
        public DateTime StartDate { get; set; }
        public string? Description { get; set; }

        public List <Topic> Topics { get; set; }
    }
}
