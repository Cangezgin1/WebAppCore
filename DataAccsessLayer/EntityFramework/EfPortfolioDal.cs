﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfPortfolioDal:GenericRepository<Portfolio>,IPortfolioDal
    {
    }
}
