using assign;
using System.Runtime.Serialization;
// See https://aka.ms/new-console-template for more information




Console.WriteLine("Welcome to user registration portal");
Console.ReadKey();

Console.WriteLine("Enter the number of courses");
int nuofcourse= int.Parse(Console.ReadLine());
List<Course> courses = new List<Course>();
for (int i = 0; i < nuofcourse; i++)
{
    Course newCourse = new Course();
    Console.WriteLine("please input course name" + (i + 1));
    newCourse.courseName = Console.ReadLine();
    Console.WriteLine("please input course credit" + (i + 1));
    newCourse.courseCredit = int.Parse(Console.ReadLine());
    Console.WriteLine("please input course grade" + (i + 1));
    newCourse.grade = Char.Parse(Console.ReadLine());
}

Console.Clear();

foreach (Course course in courses)
{
   
}

