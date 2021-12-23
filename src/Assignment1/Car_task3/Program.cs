// See https://aka.ms/new-console-template for more information

using Car_task3;
Car car = new Car();
car.Model_ID = "M-101.1";
Console.WriteLine(car.Model +" "+ car.CarType);

ElectricCar elcar = new ElectricCar("Elactric", "T-007", "Tesla");
Console.WriteLine("\n Car Model = {0} \n Car Type = {1} \n Brand Name = {2}", 
    elcar.Model,elcar.CarType,elcar.Name);
