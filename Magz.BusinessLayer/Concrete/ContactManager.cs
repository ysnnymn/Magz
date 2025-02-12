using Magz.BusinessLayer.Abstract;
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

    public List<Contact>  TGetList()
    {
        return _contactDal.GetAll();
    }

    public Contact  TGetById(int id)
    {
        return _contactDal.Get(x => x.ContactId == id);
    }

    public void  TAdd(Contact entity)
    {
_contactDal.Add(entity);

    }

    public void  TUpdate(Contact entity)
    {
_contactDal.Update(entity);

    }

    public void  TDelete(Contact entity)
    {
_contactDal.Delete(entity);

    }
}