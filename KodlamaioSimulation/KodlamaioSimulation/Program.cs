using KodlamaioSimulation.Business;
using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.DataAccess.Concretes;
using System;
using KodlamaioSimulation.Entities;
namespace KodlamaioSimulation;

class Program
{
    public static void Main(string[] args)
    {

        InstructorManager instructorManager = new InstructorManager(new InstructorDal());
        List<Instructor> instructors = instructorManager.GetAll();

        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        List<Category> categories = categoryManager.GetAll();

        CourseManager courseManager = new CourseManager(new CourseDal());
        List<Course> courses = courseManager.GetAll();
        courseManager.Add(new Course
        {
            Id = 5,
            Name = "Ruby",
            Price = 15.10,
            Description = "Ruby ile yazılım geliştirme.",
            Instructor = instructors[0],
            Category = categories[0]
        });
        courseManager.Delete(courses[0]);





        //Courses
        Console.WriteLine("-----Courses-----");
        foreach (var course in courses)
        {
            Console.WriteLine(course.Name);
            Console.WriteLine(course.Instructor.Name);
            Console.WriteLine(course.Category.Name);
            Console.WriteLine("------------");
        }


    }
}

