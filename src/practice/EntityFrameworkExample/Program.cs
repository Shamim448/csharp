using EntityFrameworkExample;

CourseDbContext courseDb = new();
//Add value in table
//Course course = new Course();
//course.Name = "C#";
//course.Fee = 9000;
//course.StartDate = DateTime.Now.AddDays(20);
//course.Description = "Full stack Asp .net MVC core";

//Course course2 = new Course();
//course2.Name = "Competative Beginner";
//course2.Fee = 7000;
//course2.StartDate = DateTime.Now.AddDays(19);
//course2.Description = "Full stack Asp";

//courseDb.Courses.Add(course);
//courseDb.Courses.Add(course2);
//courseDb.SaveChanges();


//Delete specific row 
//Course course = courseDb.Courses.Where(x => x.Id == 3).FirstOrDefault();
//courseDb.Courses.Remove(course);
//courseDb.SaveChanges();
/*
//Get all example
List< Course > courses = courseDb.Courses.ToList();
foreach( var item in courses)
{
    Console.WriteLine(item.Name);
}*/

//Update value
List <Course> courses = courseDb.Courses.Where(x => x.Name.Contains("c")).ToList();
for(int i = 0; i< courses.Count; i++)
{
    courses[i].Description = "Proffessional c#";
}
courseDb.SaveChanges();