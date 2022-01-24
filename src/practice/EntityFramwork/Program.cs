// See https://aka.ms/new-console-template for more information
using EntityFramwork;

CourseDbContext courseDb = new CourseDbContext();

/*//Insert data
Course course = new Course();
course.Title = "React Nativ";
course.Fees = 12000;
course.RegistrationEnd = DateTime.Now.AddDays(10);
course.IsActive = true;
courseDb.Courses.Add(course);

Course course2 = new Course();
course2.Title = "Python";
course2.Fees = 20000;
course2.RegistrationEnd = DateTime.Now.AddDays(20);
course2.IsActive = true;
courseDb.Courses.Add(course2);
courseDb.SaveChanges();*/

/*//view data
List<Course> allcourse = courseDb.Courses.ToList();
foreach(var course in allcourse)
{
    Console.WriteLine(course.Title);
}
*/

/*//Update data
//jodi multiple value aksathe change
//korte hoi tahole list diye dhorte hobe and for loop
//use kore value update korte hobe foreach use kora jabe na
Course  updates = courseDb.Courses.Where(x => x.Title.Contains("C")).FirstOrDefault();
updates.Title = "ASP dot net";
courseDb.SaveChanges();
*/

/*//Delete data
Course delete = courseDb.Courses.Where(x => x.IsActive==false).FirstOrDefault();
courseDb.Courses.Remove(delete);
courseDb.SaveChanges();
*/

//Note: Single value hole variable multiple value hole list use korte hobe

/*//One to many data insert
Course newCourse = new Course();
newCourse.Title = "Danjo";
newCourse.Fees = 15000;
newCourse.IsActive = true;
newCourse.RegistrationEnd = DateTime.Now.AddDays(10);

Topic topic = new Topic();
topic.Name = "Getting Started";
topic.Detail = "This is a Danjo course";

Topic topic1 = new Topic();
topic1.Name = "Write First Code";
topic1.Detail = "Write Hello World!";

newCourse.Topics = new List<Topic>();
newCourse.Topics.Add(topic);
newCourse.Topics.Add(topic1);

courseDb.Courses.Add(newCourse);
courseDb.SaveChanges();*/

//Many to many data insert
var djangoCourse = courseDb.Courses.Where(x => x.Title == "Danjo").FirstOrDefault();
var paythonCourse = courseDb.Courses.Where(x => x.Title == "Python").FirstOrDefault();
var student1 = new Student();
student1.Name = "Shamim";
var student2 = new Student();
student2.Name = "saba";

/*CourseStudent courseStudent1 = new CourseStudent();
courseStudent1.Student = student1;
CourseStudent courseStudent2 = new CourseStudent();
courseStudent2.Student = student2;*/

djangoCourse.CourseStudents = new List<CourseStudent>();
djangoCourse.CourseStudents.Add(new CourseStudent { Student = student1 });
djangoCourse.CourseStudents.Add(new CourseStudent { Student = student2 });

paythonCourse.CourseStudents = new List<CourseStudent>();
paythonCourse.CourseStudents.Add(new CourseStudent { Student = student1 });
paythonCourse.CourseStudents.Add(new CourseStudent { Student = student2 });

courseDb.SaveChanges();







