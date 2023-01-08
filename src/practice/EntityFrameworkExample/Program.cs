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
/*
 * One to many
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
*/
//select 2 course from database
var cSharp = courseDb.Courses.Where(x => x.Name == "C#").FirstOrDefault();
var devopps = courseDb.Courses.Where(x => x.Name == "Devopps").FirstOrDefault();

//create student
Student student1 = new();
student1.Name = "Anika";
var student2 = new Student();
student2.Name = "S.A Shamim";
//student add to coursestudent
CourseStudent courseStudent1 = new();
courseStudent1.Student = student1;
CourseStudent courseStudent2 = new();
courseStudent2.Student = student2;
//Add coursestudent in course
cSharp.CourseStudent = new List<CourseStudent>
{
    courseStudent1,
    courseStudent2
};

devopps.CourseStudent = new List<CourseStudent> {
    courseStudent1,
    courseStudent2
};
courseDb.SaveChanges();
