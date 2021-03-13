using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(); 
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            _categoryDal.Get(c=> c.CategoryId== categoryId);
            return new SuccessDataResult<Category>();
        }
    }
}
