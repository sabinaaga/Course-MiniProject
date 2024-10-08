﻿using Domain.Common;
using Repositories.Exceptions;
using Repositories.Helpers.Constants;
using Repositories.Repositories.Data;
using Repositories.Repositories.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BaseRepositories<T> : IBaseRepositories<T> where T : BaseEntity
    {

        private int id = 1;

        public void Create(T data)
        {
            data.Id = id;
            AppDbContext<T>.datas.Add(data);
            id++;
        }

        public void Delate(T data)
        {

            AppDbContext<T>.datas.Remove(data);

        }

        public List<T> GetAll()
        {
            return AppDbContext<T>.datas;
        }

        public T GetById(int id)
        {
            return AppDbContext<T>.datas.FirstOrDefault(x => x.Id == id) ?? throw new NotFoundexceptions(ExceptionMessages.NotFound);

        }


        public List<T> Search(string text)
        {
            return AppDbContext<T>.datas;
        }

        public List<T> GetAllGroup(string text)
        {

        return AppDbContext<T>.datas; 
        }

        public void Update(T data)
        {
            var resalt=AppDbContext<T>.datas;

        }
    }
    
}
