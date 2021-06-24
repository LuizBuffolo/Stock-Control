using ControleDeEstoque.DataBase.Interface;
using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DataBase
{
    public class ClienteDataBaseManager : IClienteDataBaseManager
    {
        public bool Insert(Cliente item)
        {
            return true;
        }

        public bool Update(Cliente item)
        {
            return true;
        }

        public bool Delete(int Id)
        {
            return true;
        }

        public Cliente GetItemById(int Id)
        {
            return null;
        }

        public List<Cliente> GetAll()
        {
            return null;
        }
    }
}
