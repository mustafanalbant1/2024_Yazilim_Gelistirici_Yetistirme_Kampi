using kodlama.io.DataAccess.Concretes;
using kodlama.io.Entities.Concretes;

namespace kodlama.io.Business.Abstracts
{
    public interface ICourseManager
    {
        List<Course> GetAll();
        Course GetById(int courseId);
        void Add(Course course);
        void Update(Course course);
        void Delete(int courseId);

        
    }
}