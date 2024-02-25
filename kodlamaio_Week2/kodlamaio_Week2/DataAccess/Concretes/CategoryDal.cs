using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities.Concretes;

namespace kodlama.io.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category(1, "Yazılım"),
                new Category(2, "Tarih"),
                new Category(3, "Edebiyat"),
                new Category(4, "Bilim")
            };
        }

        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Category Get(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    };
}