using ControleDeEstoque.Models.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DataBase.Interface
{
    public interface IDataBase<T> where T : IModel
    {
        bool Insert(T item);

        bool Update(T item);

        bool Delete(T item);

        T GetItemById(T item);

        List<T> GetAll();
    }
}
