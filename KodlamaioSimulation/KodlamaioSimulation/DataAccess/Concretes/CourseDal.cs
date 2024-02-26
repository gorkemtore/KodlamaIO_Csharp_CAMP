﻿using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        List<Instructor> instructors;
        List<Category> categories;
        public CourseDal()
        {
            IInstructorDal instructorDal = new InstructorDal();
            instructors = instructorDal.GetAll();
            ICategoryDal categoryDal = new CategoryDal();
            categories = categoryDal.GetAll();

            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".NET 8 vs...";
            course1.Price = 0;
            course1.Instructor = instructors[0];
            course1.Category = categories[0];

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "JAVA";
            course2.Description = "Java 17 ....";
            course2.Price = 10;
            course2.Instructor = instructors[0];
            course2.Category = categories[0];

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "Python 3.12...";
            course3.Price = 20;
            course3.Instructor = instructors[0];
            course3.Category = categories[0];
            courses = new List<Course> { course1, course2, course3 };
        }

        void ICourseDal.Add(Course course)
        {
            courses.Add(course);
        }

        void ICourseDal.Delete(Course course)
        {
            courses.Remove(course);
        }

        List<Course> ICourseDal.GetAll()
        {
            return courses;
        }

        void ICourseDal.Update(Course course, Course newCourse)
        {
            course.Description = newCourse.Description; 
            course.Price = newCourse.Price;
            course.Name = newCourse.Name;
            course.Id = newCourse.Id;
            course.Instructor = newCourse.Instructor;
            course.Category = newCourse.Category;
        }
    }
}
