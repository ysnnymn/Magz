using Magz.CoreLayer.DataAccess.EntityFramework;
using Magz.DataAccessLayer.Abstract;
using Magz.DataAccessLayer.Context;
using Magz.EntityLayer.Concrete;

namespace Magz.DataAccessLayer.Concrete;

public class EfAuthorDal:EfEntityRepositoryBase<Author,MagzContext>,IAuthorDal
{
    
}