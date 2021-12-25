// See https://aka.ms/new-console-template for more information

using Car_task3;
Car car = new Car();
car.Model_ID = "M-101.1";
Console.WriteLine(car.Model +" "+ car.CarType);

//ElectricCar elcar = new ElectricCar("Elactric", "T-007", "Tesla");
//Console.WriteLine("\n Car Model = {0} \n Car Type = {1} \n Brand Name = {2}", 
//   elcar.Model,elcar.CarType,elcar.Name);

Tesla tesla = new Tesla("Tesla", "Electric", "red");
tesla.GetCarModel("Model", 's');
Console.WriteLine("\nBrand Name = {0} \nModel = {1} \nCar Type = {2}\n Car Color= {3}  ",
    tesla.BrandName, tesla.Model , tesla.CarType , tesla.Color);

Ford ford = new Ford("Ford", "Disel","Blue",  2021);
ford.GetCarModel("Ford", "Endeavour");
Console.WriteLine("\nBrand Name = {0} \nModel = {1} \nCar Color = {2}\nCar Type = {3} \nYear ={4}  ",
    ford.BrandName , ford.Model,  ford.Color, ford.CarType, ford.Year);

BMW bmw = new BMW("BMW", "Disel", "Black", 2021, 150);
bmw.GetCarModel('3', "Series");
Console.WriteLine("\nBrand Name = {0} \nModel = {1} \nCar Color = {2}\nCar Type = {3} \nYear ={4} \nSpeed={5} ",
    bmw.BrandName, bmw.Model, bmw.Color, bmw.CarType, bmw.Year, bmw.Speed);

