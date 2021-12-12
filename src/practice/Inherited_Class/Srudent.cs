using Clasess;
namespace InheritedClass { 
    public class Student
    {
        public string name { get; set; }
    }
//inherited class from teacher
class headmaster: Teachar
{
    public void getaddress()
    {
        //get address from protected type teacher class
        address = "kashimpur"; 
    }
}
}
