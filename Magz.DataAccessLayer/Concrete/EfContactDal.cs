using Magz.CoreLayer.DataAccess.EntityFramework;
using Magz.DataAccessLayer.Abstract;
using Magz.DataAccessLayer.Context;
using Magz.EntityLayer.Concrete;

namespace Magz.DataAccessLayer.Concrete;

public class EfContactDal:EfEntityRepositoryBase<Contact,MagzContext>,IContactDal
{
    
}