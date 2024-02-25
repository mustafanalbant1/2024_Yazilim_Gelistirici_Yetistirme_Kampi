using kodlama.io.Entities.Abstracts;

namespace kodlama.io.Entities.Concretes;
    public class Instructor: IEntity
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public Instructor(int id, string name, string lastName, string image, string description, int v)
        {
            InstructorId = id;
            InstructorName = name;
            LastName = lastName;
            Image = image;
            Description = description;
        }
  
    }
