namespace Car_task3
{
    public class Car
    {
        public string Model;
        public string Color;
        public int Year;
        public string Status;
        public string CarType = string.Empty;
        public int speed = 0;
        public Car()
        {
           
        }
        //Over Load 1
        public Car(string type, string color)
        {
            CarType = type;
            Color = color;


        }
        //Overload 2
        public Car(string model, string name, double enginetype)
        {
     
        }

        public string Model_ID { get {
                return Model;
            }
            set
            {
                Model = value;
            }
        }
        public void GetCarModel()
        {
            Model = "abc-001";
        }
        public void Start()
        {
            Status = "Car is moving";
        }
        public void Stop()
        {
            Status = "Car is not moving";
        }

    }
}
