using kodlama.io.Entities.Abstracts;

namespace kodlama.io.Entities.Concretes
{
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

    }
};