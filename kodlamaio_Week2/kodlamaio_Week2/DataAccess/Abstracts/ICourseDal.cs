using kodlama.io.Entities.Concretes;

namespace kodlama.io.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(int courseId);
        void Update(Course course);
        Course Get(int courseId);
        
    }
};