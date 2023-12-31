﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);   
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category TGetByID(int id)
        {
          return  _categoryDal.GetByID(id);
        }

        public void TUpdate(Category entity)
        {
           _categoryDal.Update(entity); 
        }
    }
}
