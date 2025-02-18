using Magz.BusinessLayer.Abstract;
using Magz.BusinessLayer.Constants;
using Magz.CoreLayer.Utilities.Results;
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

    public IDataResult<List<Category>>  TGetList()
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
    }

    public IDataResult<Category>  TGetById(int id)
    {
        return new SuccessDataResult<Category>(_categoryDal.Get(x => x.CategoryId == id));

    }

    public IResult  TAdd(Category entity)
    {
_categoryDal.Add(entity);
return new SuccessResult(Messages.CategoryAdded);

    }

    public IResult  TUpdate(Category entity)
    {
_categoryDal.Update(entity);
return  new SuccessResult(Messages.CategoryUpdated);

    }

    public IResult  TDelete(Category entity)
    {
_categoryDal.Delete(entity);
return new SuccessResult(Messages.CategoryDeleted);

    }
}