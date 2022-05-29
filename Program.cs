// See https://aka.ms/new-console-template for more information
using EntityFrameworkProject;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System.Linq;

Console.WriteLine("Hello, World!");


// 1 ***

var studentList = new List<Student>() { new Student() { Name = "Jonas" }, new Student() { Name = "Antanas" }, new Student() { Name = "Kipras" } };  
var coursesList = new List<Course>() { new Course() { Name = "Mathematics"}, new Course() { Name = "Physics"}, new Course() { Name = "Geometry" } };

SchoolDbService.CreateDepartamentAndAddStudentsAndCourses("Technology", studentList, coursesList);



// 2 ***

var courses = new List<Course>();
courses.Add(new Course() { Name = "Astronomy" });
courses.Add(new Course() { Name = "Algebra" });
courses.Add(new Course() { Name = "Trigonometry" });

var students = new List<Student>();
students.Add(new Student() { Name = "Marija" });
students.Add(new Student() { Name = "Kazys" });

SchoolDbService.AddStudentsAndCoursesToEgsistingDepartament(5, students, courses);

// 3 ***

SchoolDbService.CreateCourseAndAddToExistingDepartament("Logic", 3);

// 4 ***

SchoolDbService.CreateStudentAndAddToEgsistingDepartament("Juozas", 3) ;

// 5 ***

SchoolDbService.TransferStudentToOtherDepartament(1, 2);
 
// 6 ***

SchoolDbService.PrintAllStudentsOfDepartament(5);

// 7 ***

SchoolDbService.PrintAllCoursesOfDepartament(2);


