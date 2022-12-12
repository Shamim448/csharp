using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
 class Teacher
    {
        public int age;
        public string name;
        protected int salary;
        private string id;
        public void generateId()
        {
            id = "T-" + DateTime.Now.Ticks;
        }
        public string Id { get { return id; } }
        
    }
    //Used protected chield class
    class Headmaster : Teacher
    {
        public void setSalary() { 
            salary = 20000;
        }
    }
}
