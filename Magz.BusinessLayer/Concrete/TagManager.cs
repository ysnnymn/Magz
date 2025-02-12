using Magz.BusinessLayer.Abstract;
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

    public List<Tag> TGetList()
    {
        return _tagDal.GetAll();
    }

    public Tag TGetById(int id)
    {
        return _tagDal.Get(x=>x.TagId == id);
    }

    public void TAdd(Tag entity)
    {
         _tagDal.Add(entity);
    }

    public void TUpdate(Tag entity)
    {
_tagDal.Update(entity);

    }

    public void TDelete(Tag entity)
    {
_tagDal.Delete(entity);

    }
}