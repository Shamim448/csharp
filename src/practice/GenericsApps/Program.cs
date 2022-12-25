
using GenericsApps;

Box <Book> b = new Box<Book>();
b.Add(new Book() {Name ="Novel", Price = 320});
b.Add(new Book() {Name ="C#", Price = 320});

Box<Shart> s= new Box<Shart>();
s.Add(new Shart() { Name = "Formal", Color = "Red" });
s.Add(new Shart() { Name = "Casual", Color = "Black" });

Book book = b.Get(1);
Console.WriteLine(book.Name);


