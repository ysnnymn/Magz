using Magz.BusinessLayer.Abstract;
using Magz.CoreLayer.Utilities.Results;
using Magz.DataAccessLayer.Abstract;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Concrete;

public class ContactManager:IContactService
{
    IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public IDataResult<List<Contact>>  TGetList()
    {
        return  new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
    }

    public IDataResult<Contact>  TGetById(int id)
    {
        return new SuccessDataResult<Contact>(_contactDal.Get(x => x.ContactId == id)) ;
    }

    public IResult  TAdd(Contact entity)
    {
_contactDal.Add(entity);
return new SuccessResult();
    }

    public IResult  TUpdate(Contact entity)
    {
_contactDal.Update(entity);
return new SuccessResult();

    }

    public IResult  TDelete(Contact entity)
    {
_contactDal.Delete(entity);
return new SuccessResult();

    }
}