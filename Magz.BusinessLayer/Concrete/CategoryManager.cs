using Magz.BusinessLayer.Abstract;
using Magz.DataAccessLayer.Abstract;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Concrete;

public class CategoryManager: ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category>  TGetList()
    {
        return _categoryDal.GetAll();
    }

    public Category  TGetById(int id)
    {
return    _categoryDal.Get(x=>x.CategoryId == id);

    }

    public void  TAdd(Category entity)
    {
_categoryDal.Add(entity);

    }

    public void  TUpdate(Category entity)
    {
_categoryDal.Update(entity);

    }

    public void  TDelete(Category entity)
    {
_categoryDal.Delete(entity);

    }
}