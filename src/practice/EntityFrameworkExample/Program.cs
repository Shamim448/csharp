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

/*
//Update value
List <Course> courses = courseDb.Courses.Where(x => x.Name.Contains("c")).ToList();
for(int i = 0; i< courses.Count; i++)
{
    courses[i].Description = "Proffessional c#";
}
courseDb.SaveChanges();
*/

//new coursw
Course newCourse = new();
newCourse.Name = "Devopps";
newCourse.Fee = 20000;
newCourse.StartDate = DateTime.Now;
newCourse.Description = "Devopps Basic to advance";

//create topic
Topic topic = new();
topic.Name = "Getting Started";
topic.Detail = "Tools Installation";
Topic topic2 = new();
topic2.Name = "Getting Started";
topic2.Detail = "Tools Installation";

//Topic add to course
newCourse.Topics = new List<Topic>();
newCourse.Topics.Add(topic);
newCourse.Topics.Add(topic2);

//new courses add to courses
courseDb.Courses.Add(newCourse);
courseDb.SaveChanges();
