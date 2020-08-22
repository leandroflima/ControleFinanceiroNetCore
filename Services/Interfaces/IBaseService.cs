using ControleFinanceiroNetCore.Models;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Services
{
    public interface IBaseService<T> where T : BaseModel
    {
        List<T> Get();
        T Get(Guid id);
        T Create(T model);
        void Update(Guid id, T model);
        void Remove(T modelIn);
        void Remove(Guid id);
    }
}
