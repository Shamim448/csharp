using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    public class MedicinInfo
    {
        public int ID { get; set; }
        public string? MedicineName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; } 
        public DateTime PurchaseDate { get; set; }
        public List<Dispansary> Pharmecy { get; set; }
    }
}
