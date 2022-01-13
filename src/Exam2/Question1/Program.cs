using Question1;
AnalogScale<int>analog = new AnalogScale<int>();
var analogweight =  analog.Weight = 5;

Console.WriteLine(analogweight);

DigitalScale<double> digital = new DigitalScale<double>();
digital.Weight = 40.5;

