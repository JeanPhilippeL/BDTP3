﻿using app.domain.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain.Services
{
    public interface IClientRepository<T> where T : Client
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        void Delete(T entity);
        void Add(T entity);
        void Update(T entity);
    }
}