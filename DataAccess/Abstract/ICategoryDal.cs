﻿using System;
using Core.DataAccess;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}

