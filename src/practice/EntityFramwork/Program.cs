// See https://aka.ms/new-console-template for more information
using EntityFramwork;

CourseDbContext courseDb = new CourseDbContext();

/*//Insert data
Course course = new Course();
course.Title = "Computer Fundamental";
course.Fees = 4000;
course.RegistrationEnd = DateTime.Now.AddDays(10);
course.IsActive = false;
courseDb.Courses.Add(course);

Course course2 = new Course();
course2.Title = "Comprtative programming";
course2.Fees = 5000;
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






