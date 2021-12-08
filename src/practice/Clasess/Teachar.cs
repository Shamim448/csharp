using System;
public class Teachar
{
    internal int age = 30;
    public string name = "Shohaib";
    protected internal string address;
    public string id;
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
    public void GenerateNewId()
    {
        id = "T-" + DateTime.Now.Ticks;
    }

}


