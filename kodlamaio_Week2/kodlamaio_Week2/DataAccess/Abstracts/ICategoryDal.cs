using kodlama.io.Entities.Concretes;

namespace kodlama.io.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category category);
        Category Get(int CategoryId);
        
    }
};                              