using Magz.BusinessLayer.Abstract;
using Magz.CoreLayer.Utilities.Results;
using Magz.DataAccessLayer.Abstract;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Concrete;

public class TagManager:ITagService
{
    ITagDal _tagDal;

    public TagManager(ITagDal tagDal)
    {
        _tagDal = tagDal;
    }

    public IDataResult<List<Tag>> TGetList()
    {
        return new SuccessDataResult<List<Tag>>(_tagDal.GetAll()) ;
    }

    public IDataResult<Tag> TGetById(int id)
    {
        return new SuccessDataResult<Tag>(_tagDal.Get(x=>x.TagId == id)) ;
    }

    public IResult TAdd(Tag entity)
    {
         _tagDal.Add(entity);
         return new SuccessResult();
    }

    public IResult TUpdate(Tag entity)
    {
_tagDal.Update(entity);
return new SuccessResult();

    }

    public IResult TDelete(Tag entity)
    {
_tagDal.Delete(entity);
return new SuccessResult();

    }
}