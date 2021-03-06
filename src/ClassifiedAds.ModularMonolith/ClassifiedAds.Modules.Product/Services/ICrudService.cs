﻿using ClassifiedAds.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ClassifiedAds.Modules.Product.Services
{
    public interface ICrudService<T>
        where T : AggregateRoot<Guid>
    {
        IList<T> Get();

        T GetById(Guid guid);

        void AddOrUpdate(T entity);

        void Delete(T entity);
    }
}
