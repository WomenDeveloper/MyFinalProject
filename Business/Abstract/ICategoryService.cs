﻿using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);

    }
}

