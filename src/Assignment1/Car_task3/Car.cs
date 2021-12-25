namespace Car_task3
{
    public class Car
    {
        public string Model;
        public string Color;
        public int Year;
        public string Status;
        public string CarType = string.Empty;
        public int Speed = 0;
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
        public Car(string type, string color, int year)
        {
            CarType = type;
            Color = color;
            Year = year;
        }
        public Car(string type, string color, int year, int speed)
        {
            CarType = type;
            Color = color;
            Year = year;
            Speed = speed;

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
        public void GetCarModel(string model, char prefix)
        {
            Model = model + " " + prefix;
        }
        public void GetCarModel(string firstname, string lastname)
        {
            Model = firstname + " " + lastname;
        }
        public void GetCarModel(char prefix, string lastname)
        {
            Model = prefix + " " + lastname;
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
