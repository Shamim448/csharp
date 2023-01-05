using EntityFrameworkExample;

CourseDbContext courseDb = new();
Course course = new Course();
course.Name = "Asp dotNet";
course.Fee = 30000;
course.StartDate = DateTime.Now.AddDays(9);
course.Description = "Full stack Asp .net MVC core";

courseDb.Courses.Add(course);
courseDb.SaveChanges();
