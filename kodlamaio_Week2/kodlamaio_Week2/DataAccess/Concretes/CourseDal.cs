using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities.Concretes;

namespace kodlama.io.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course(1, "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", "description", 0, 1, 1),
                new Course(2, "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", "description", 0, 1, 1),
                new Course(3, "Programlamaya Giriş için Temel Kurs", "description", 0, 1, 1),
            };
        }

        public void Add(Course course)
        {
            throw new NotImplementedException();
        }

        public void Delete(int courseId)
        {
            throw new NotImplementedException();
        }

        public Course Get(int courseId)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}