using System;
namespace Clasess {
public class Teachar
{
        internal int age;
    public string name ;
    protected internal string address;
    private string id;
    public string Id
    {
        get { return id; }
        set
        {
            if (value.StartsWith("T-"))
            {
                id = value;
            }
        }
    }
        // Constractor use for add default value of class field.
        public Teachar()
        {
            age = 28;
            name = string.Empty;
        }
    //auto property
    public DateTime DateOfBirth { get; set; }
    public void GenerateNewId()
    {
        id = "T-" + DateTime.Now.Ticks;
    }
        // method overloading
    public void GenerateNewId(string id)
        {
            this.id = "T-" + id;
        }
        public void GenerateNewId(string prefix, int id)
        {
            this.id = prefix + id;
        }
        public void GenerateNewId( int id, string prefix)
        {
            this.id = prefix + id;
            
        }
        Student student = new Student();
}

}
