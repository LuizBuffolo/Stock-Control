using ControleDeEstoque.Models.Interface;
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

        bool Delete(int Id);

        T GetItemById(int Id);

        List<T> GetAll();
    }
}
