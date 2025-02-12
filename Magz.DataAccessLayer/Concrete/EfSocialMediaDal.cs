using Magz.CoreLayer.DataAccess.EntityFramework;
using Magz.DataAccessLayer.Abstract;
using Magz.DataAccessLayer.Context;

namespace Magz.DataAccessLayer.Concrete;

public class EfSocialMediaDal:EfEntityRepositoryBase<SocialMedia,MagzContext>,ISocialMediaDal
{
    
}