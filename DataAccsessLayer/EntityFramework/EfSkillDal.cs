using System;
using System.Collections.Generic;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfSkillDal:GenericRepository<Skill>,ISkillDal
    {
    }
}
