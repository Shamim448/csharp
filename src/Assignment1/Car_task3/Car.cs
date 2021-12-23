namespace Car_task3
{
    public class Car
    {
        public string Model;
        public string Name = string.Empty;
        public double EngineType;
        public string CarType = string.Empty;
        public Car()
        {
                        
        }
        //Over Load 1
        public Car(string model, string name)
        {
            this.Model = model;
            this.Name = name;
        }
        //Overload 2
        public Car(string model, string name, double enginetype)
        {
            this.Model = model;
            this.Name = name;
            this.EngineType = enginetype;
        }

        public string Model_ID { get {
                return Model;
            }
            set
            {
                Model = value;
            }
        }
    }
}
