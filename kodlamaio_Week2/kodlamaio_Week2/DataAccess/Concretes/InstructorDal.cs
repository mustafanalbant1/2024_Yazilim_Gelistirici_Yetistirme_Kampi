using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities.Concretes;

namespace kodlama.io.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor(1, "Engin" , "Demiroğ", "image", "description", 1),
                new Instructor(2, "Kerem", "Varış", "image", "description", 1),
                new Instructor(3, "Berkay", "Bilgin", "image", "description", 1),
            };
        }

        public void Add(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int instructorId)
        {
            throw new NotImplementedException();
        }

        public Instructor Get(int instructorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}