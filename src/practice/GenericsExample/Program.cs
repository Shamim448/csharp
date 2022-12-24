using GenericsExample;
//For using tuple we can create different of instance 

Points <int> point = new Points<int>();
point.X = 20; point.Y = 20; //we can assign integer

Points <double> points = new Points<double>();
points.X = 15.6; points.Y = 14.36;

int z = point.X + point.Y;

Points <string> points2 = new Points<string>();
points2.X = "South"; points2.Y = "North";

//some generics type method
List <int> list = new List<int>();
list.Add(z);
list.Add(point.X);
list.Add(50);
Dictionary<int, string> map = new Dictionary<int, string>();
map.Add(0, "shamim");
Console.WriteLine(map[0]);
LinkedList<int> l = new LinkedList<int>();
l.AddFirst(z);
l.AddLast(point.X);