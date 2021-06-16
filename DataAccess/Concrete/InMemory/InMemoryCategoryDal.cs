using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal:ICategoryDal
    {
        List<Category> _category;

        public InMemoryCategoryDal()
        {
            _category = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="kategori 1"},
                new Category{CategoryId=2,CategoryName="Kategori 2"},
                new Category{CategoryId=3,CategoryName="Kategori 3"},
                new Category{CategoryId=4,CategoryName="Kategori 4"},
                new Category{CategoryId=5,CategoryName="Kategori 5"},
                new Category{CategoryId=6,CategoryName="Kategori 6"}

            };
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
