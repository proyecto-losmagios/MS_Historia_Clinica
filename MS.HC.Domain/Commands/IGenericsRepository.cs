using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS.HC.Domain.Commands
{
    public interface IGenericsRepository
    {
        public interface IGenericsRepository
        {
            void Add<T>(T entity) where T : class;
            IQueryable<T> GetAll<T>() where T : class;
            T FindById<T>(int id) where T : class;

        }

        void Add<T>(T entity);
    }
}