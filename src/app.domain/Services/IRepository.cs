﻿using app.domain.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        void Delete(T entity);
        void Add(T entity);
        void Update(T entity);
    }


}
