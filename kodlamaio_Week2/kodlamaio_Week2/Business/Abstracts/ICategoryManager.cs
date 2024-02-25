using kodlama.io.DataAccess.Concretes;
using kodlama.io.Entities.Concretes;

namespace kodlama.io.Business.Abstracts
{
    public interface ICategoryManager
    {
        List<Category> Get();
        Category Id(int categoryId);
    }

}