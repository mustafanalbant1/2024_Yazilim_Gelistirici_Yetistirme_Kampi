using kodlama.io.Entities.Concretes;

namespace kodlama.io.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(int instructorId);
        void Update(Instructor instructor);
        Instructor Get(int instructorId);
        
        
    }
};