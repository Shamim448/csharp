using System;
public class Teachar
{
    internal int age = 30;
    public string name = "Shohaib";
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
    //auto property
    public DateTime DateOfBirth { get; set; }
    public void GenerateNewId()
    {
        id = "T-" + DateTime.Now.Ticks;
    }

}


