using kodlama.io.DataAccess.Concretes;
using kodlama.io.Entities.Concretes;

namespace kodlama.io.Business.Abstracts
{
    public interface IInstructorManager
    {
        List<Instructor> GetAll();
        Instructor GetById(int instructorId);
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int instructorId);
        
    }
}