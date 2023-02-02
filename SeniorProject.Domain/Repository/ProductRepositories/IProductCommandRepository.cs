﻿using SeniorProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Domain.Repository.ProductRepository
{
    public  interface IProductCommandRepository:ICommandRepository<Product>
    {
    }
}
