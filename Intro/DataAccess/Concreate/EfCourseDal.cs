using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concreate;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;
    public EfCourseDal ()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "Javascript";
        course1.Description = "JS ...";
        course1.Price = 5;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Flutter";
        course2.Description = "Flutter ....";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Angular";
        course3.Description = "Angular 17...";
        course3.Price = 20;

        courses = new List<Course> { course1, course2, course3 };
    }


    public List<Course> GetAll ()
    {
        return courses;
    }

    public void Add (Course course)
    {
        courses.Add(course);
    }
}