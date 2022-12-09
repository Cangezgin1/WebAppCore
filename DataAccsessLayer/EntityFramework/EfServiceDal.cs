using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfServiceDal:GenericRepository<Service>,IServiceDal
    {
    }
}
