using kodlama.io.Entities.Abstracts;


namespace kodlama.io.Entities.Concretes;


public class Course : IEntity
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public int CoursePrice { get; set; }
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }

    public Course(int id, string name, string description, int price, int instructorId, int categoryId)
    {
        CourseId = id;
        CourseName = name;
        CourseDescription = description;
        CoursePrice = price;
        InstructorId = instructorId;
        CategoryId = categoryId;
    }

}
